using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auctions.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public int SellerId { get; set; }
        public User Seller { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        [MinLength(10)]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double StartBid { get; set; }
        [DataType(DataType.Currency)]
        public double HighestBid { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; }
        public List<Bid> Bids { get; set; }
    }
}
