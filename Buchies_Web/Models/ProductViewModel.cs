using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Buchies_Web.Models
{
    public class ProductViewModel
    {
        [Required]
        [Display(Name = "ProductId")]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "ProductName")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Rate")]
        public decimal Rate { get; set; }

        
    }
}