using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Buchies_Web.Models
{
    public class UserViewModel
    {
        [Required]
        [Display(Name = "UserId")]
        public int UserId { get; set; }

        [Required]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; }

        //public int ProductId { get; set; }
        //public string ProductName { get; set; }
        //public int Quantity { get; set; }
        //public decimal Rate { get; set; }


    }
}