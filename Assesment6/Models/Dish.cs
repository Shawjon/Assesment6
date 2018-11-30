using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assesment6.Models
{
    public class Dish
    {
        public Dish()
        {
        }

        public Dish(string name, string phoneNumber, string dishName, string dishDescription, string dietary)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            DishName = dishName;
            DishDescription = dishDescription;
            Dietary = "N/A";
        }

        public string Name { get; set; }
        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }
        public string DishName { get; set; }
        public string DishDescription { get; set; }
        public string Dietary { get; set; }
    }
}