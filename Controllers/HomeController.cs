using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Auctions.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace Auctions.Controllers
{
    public class HomeController : Controller
    {
        private Context dbContext;

        public HomeController(Context context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            User newUser = new User();

            return View();
        }

        [HttpPost("login")]
        public IActionResult Login(string LoginUsername, string LoginPassword)
        {
            User newUser = new User();
            User loggedIn = dbContext.Users.SingleOrDefault(u => u.Username == LoginUsername);

            if(loggedIn != null)
            {
                if (LoginPassword != null)
                {
                    var hasher = new PasswordHasher<User>();
                    var result = hasher.VerifyHashedPassword(newUser, loggedIn.Password, LoginPassword);

                    if (result != 0)
                    {
                        HttpContext.Session.SetObjectAsJson("LoggedIn", loggedIn);
                        return RedirectToAction("Dashboard");
                    }
                    else
                    {
                        ViewBag.PasswordError = "Incorrect password";
                    }
                }else
                {
                    ViewBag.PasswordError = "Password is required";
                }
            } else
            {
                ViewBag.UsernameError = "Username does not exist"; 
            }
            return View("Index");
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                User checkName = dbContext.Users.SingleOrDefault(u => u.Username == newUser.Username);

                if(checkName == null)
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);

                    newUser.Wallet = 1000.00;
                    newUser.CreatedAt = DateTime.Now;
                    newUser.UpdatedAt = DateTime.Now;
                    dbContext.Users.Add(newUser);
                    dbContext.SaveChanges();

                    HttpContext.Session.SetObjectAsJson("LoggedIn", newUser);
                    return RedirectToAction("Dashboard");
                }
            }

            User userModel = new User();
            return View("Index", userModel);
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            ViewBag.SessionUser = HttpContext.Session.GetObjectFromJson<User>("LoggedIn");

            if (ViewBag.SessionUser != null)
            {
                List<Product> AllProds = dbContext.Products
                    .Include(p => p.Seller)
                    .Include(p => p.Bids)
                    .ThenInclude(b => b.User)
                    .OrderBy(p => p.EndDate)
                    .ToList();

                foreach(Product prod in AllProds)
                {
                    if(prod.EndDate < DateTime.Now)
                    {
                        prod.Seller.Wallet += prod.HighestBid;
                        Bid bid = dbContext.Bids.Include(c => c.User).SingleOrDefault(b => b.ProductId == prod.ProductId && b.Amount == prod.HighestBid);

                        if (bid != null)
                        {
                            bid.User.Wallet -= prod.HighestBid;
                        }

                        dbContext.Products.Remove(prod);
                        dbContext.SaveChanges();
                    }
                }

                return View(AllProds);
            }
            return RedirectToAction("Index");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            User sessionUser = HttpContext.Session.GetObjectFromJson<User>("LoggedIn");
            Product prod = dbContext.Products.SingleOrDefault(p => p.ProductId == id);

            if (sessionUser.UserId == prod.SellerId)
            {
                dbContext.Products.Remove(prod);
                dbContext.SaveChanges();

                return RedirectToAction("Dashboard");
            }
            return RedirectToAction("Dashboard");
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            User sessionUser = HttpContext.Session.GetObjectFromJson<User>("LoggedIn");

            if (sessionUser != null)
            {
                Product prod = new Product();

                return View("NewAuction", prod);
            }
            return RedirectToAction("Index");
        }

        [HttpPost("new")]
        public IActionResult CreateNew(Product newProd)
        {
            if(ModelState.IsValid)
            {
                if(newProd.StartBid > 0)
                {
                    if(newProd.EndDate > DateTime.Now)
                    {
                        User sessionUser = HttpContext.Session.GetObjectFromJson<User>("LoggedIn");

                        newProd.SellerId = sessionUser.UserId;
                        newProd.HighestBid = newProd.StartBid;
                        newProd.CreatedAt = DateTime.Now;
                        newProd.UpdatedAt = DateTime.Now;
                        dbContext.Products.Add(newProd);
                        dbContext.SaveChanges();

                        return RedirectToAction("Dashboard");
                    } else
                    {
                        ModelState.AddModelError("EndDate", "End date must be in the future");
                    }
                } else
                {
                    ModelState.AddModelError("StartBid", "Starting Bid must be greater than 0");
                }
            }

            Product prod = new Product();

            return View("NewAuction", prod);
        }

        [HttpGet("product/{id}")]
        public IActionResult ShowProduct(int id)
        {
            User sessionUser = HttpContext.Session.GetObjectFromJson<User>("LoggedIn");

            if (sessionUser != null)
            {
                Product prod = dbContext.Products
                    .Include(p => p.Seller)
                    .Include(p => p.Bids)
                    .ThenInclude(b => b.User)
                    .SingleOrDefault(p => p.ProductId == id);

                List<Bid> highest = dbContext.Bids
                    .Include(b => b.User)
                    .Include(b => b.Product)
                    .OrderByDescending(b => b.Amount)
                    .Where(c => c.ProductId == id)
                    .ToList();

                if (highest.Count > 0)
                {
                    ViewBag.HighestBid = highest[0];
                } else
                {
                    ViewBag.HighestBid = null;
                }


                return View(prod);
            }
            return RedirectToAction("Index");
        }

        [HttpPost("bid/{id}")]
        public IActionResult NewBid(int id, double UserBid)
        {
            User sessionUser = HttpContext.Session.GetObjectFromJson<User>("LoggedIn");
            Product prod = dbContext.Products.Include(c => c.Seller).SingleOrDefault(p => p.ProductId == id);

            if (UserBid > 0)
            {

                if (UserBid <= sessionUser.Wallet && UserBid > prod.HighestBid)
                {
                    Bid newBid = new Bid();

                    newBid.ProductId = id;
                    newBid.UserId = sessionUser.UserId;
                    newBid.Amount = UserBid;
                    newBid.CreatedAt = DateTime.Now;
                    newBid.UpdatedAt = DateTime.Now;
                    dbContext.Bids.Add(newBid);
                    dbContext.SaveChanges();

                    Bid highestBid = dbContext.Bids.OrderByDescending(b => b.Amount).Where(c => c.ProductId == id).First();

                    prod.HighestBid = highestBid.Amount;
                    dbContext.SaveChanges();

                    return RedirectToAction("Dashboard");
                }
                else
                {
                    ViewBag.BidError = "You cannot bid more than you have in your wallet or less than the current highest bid";
                }
            } else
            {
                ViewBag.BidError = "Bids must be a positive number";
            }

            return View("ShowProduct", prod);
        }

    }

    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            string value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
