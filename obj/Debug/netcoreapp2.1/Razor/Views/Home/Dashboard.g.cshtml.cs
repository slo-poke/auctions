#pragma checksum "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d8895f068deed7f0af8c76717c716f02985f58b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\_ViewImports.cshtml"
using Auctions;

#line default
#line hidden
#line 1 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\Dashboard.cshtml"
using Auctions.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d8895f068deed7f0af8c76717c716f02985f58b", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bea55a7b78ce2fb8d02008b61d6edeba4a7a9df", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 67, true);
            WriteLiteral("\r\n<div class=\"inline\">\r\n    <h1>Current Auctions</h1>\r\n    <h5>Hi, ");
            EndContext();
            BeginContext(114, 29, false);
#line 6 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\Dashboard.cshtml"
       Write(ViewBag.SessionUser.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(143, 223, true);
            WriteLiteral("</h5>\r\n    <a href=\"/logout\">Logout</a>\r\n</div>\r\n\r\n<table class=\"dash\">\r\n    <tr>\r\n        <th>Product</th>\r\n        <th>Seller</th>\r\n        <th>Top Bid</th>\r\n        <th>Time Remaining</th>\r\n        <th></th>\r\n    </tr>\r\n");
            EndContext();
#line 18 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\Dashboard.cshtml"
      
        foreach (Product prod in Model)
        {

#line default
#line hidden
            BeginContext(426, 40, true);
            WriteLiteral("            <tr>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 466, "\"", 497, 2);
            WriteAttributeValue("", 473, "/product/", 473, 9, true);
#line 22 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 482, prod.ProductId, 482, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(498, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(500, 9, false);
#line 22 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\Dashboard.cshtml"
                                                  Write(prod.Name);

#line default
#line hidden
            EndContext();
            BeginContext(509, 31, true);
            WriteLiteral("</a></td>\r\n                <td>");
            EndContext();
            BeginContext(541, 21, false);
#line 23 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\Dashboard.cshtml"
               Write(prod.Seller.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(562, 28, true);
            WriteLiteral("</td>\r\n                <td>$");
            EndContext();
            BeginContext(591, 15, false);
#line 24 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\Dashboard.cshtml"
                Write(prod.HighestBid);

#line default
#line hidden
            EndContext();
            BeginContext(606, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 25 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\Dashboard.cshtml"
                  
                    TimeSpan days = prod.EndDate - DateTime.Now;
                    days.ToString();

#line default
#line hidden
            BeginContext(737, 24, true);
            WriteLiteral("                    <td>");
            EndContext();
            BeginContext(762, 9, false);
#line 28 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\Dashboard.cshtml"
                   Write(days.Days);

#line default
#line hidden
            EndContext();
            BeginContext(771, 14, true);
            WriteLiteral(" day(s)</td>\r\n");
            EndContext();
            BeginContext(805, 20, true);
            WriteLiteral("                <td>");
            EndContext();
#line 30 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\Dashboard.cshtml"
                      
                    if(prod.SellerId == ViewBag.SessionUser.UserId)
                    {

#line default
#line hidden
            BeginContext(921, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 947, "\"", 977, 2);
            WriteAttributeValue("", 954, "/delete/", 954, 8, true);
#line 33 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 962, prod.ProductId, 962, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(978, 13, true);
            WriteLiteral(">Delete</a>\r\n");
            EndContext();
#line 34 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\Dashboard.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(1031, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 37 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\Dashboard.cshtml"
        }
    

#line default
#line hidden
            BeginContext(1075, 114, true);
            WriteLiteral("</table>\r\n<div class=\"inline\">\r\n    <a href=\"/new\"><button>New Auction</button></a>\r\n    <p>Your Current Wallet: $");
            EndContext();
            BeginContext(1190, 26, false);
#line 42 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\Dashboard.cshtml"
                        Write(ViewBag.SessionUser.Wallet);

#line default
#line hidden
            EndContext();
            BeginContext(1216, 16, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
