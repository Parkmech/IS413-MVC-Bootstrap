//Parker Mecham, Section 1

using System;
using System.ComponentModel.DataAnnotations;

namespace BestRestaurants.Models
{
    public class AddRestaurant
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string RestaurantName { get; set; }


        public string? FaveDish { get; set; }

        [Phone]
        [RegularExpression ("^[0-9]{3}-[0-9]{3}-[0-9]{4}$", ErrorMessage = "Please Enter a Valid Phone Number ( xxx-xxx-xxxx )")]
        public string? PhoneNum { get; set; }

    }
}
