using System.ComponentModel.DataAnnotations;
using MovieShop.MVC.Validators;

namespace MovieShop.MVC.Models
{
    public class PurchaseRequestModel
    {
        public int MovieId { get; set; }

        [Required]
        [DateNotInPast]
        public DateTime PurchaseDateTime { get; set; }

        [Required]
        [Range(0.01, 9999.99)]
        public decimal TotalPrice { get; set; }

        public int UserId { get; set; } 
    }
}