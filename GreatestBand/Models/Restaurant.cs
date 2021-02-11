//Parker Mecham, Section 1

using System;
using System.ComponentModel.DataAnnotations;

namespace BestRestaurants.Models
{
    public class Restaurant
    {

        public Restaurant(int rank)
        {
            RestaurantRank = rank;
        }

        [Required]
        public int RestaurantRank { get; }

        [Required]
        public string RestaurantName { get; set; }

        public string? FaveDish { get; set; }

        [Required]
        public string Address { get; set; }

        [Phone]
        public string? PhoneNum { get; set; }

        public string? WebsiteLink { get; set; }

        public static Restaurant[] GetRestaurants()

        {

            Restaurant r1 = new Restaurant(1)
            {
                RestaurantName = "Bombay House",
                FaveDish = "Chicken Tikka Masala",
                Address = "463 N University Ave, Provo, UT 84601",
                PhoneNum = "(801)373-6677",
                WebsiteLink = "https://bombayhouse.com"
            };

            //This section demonstrates that the default value of the website section works
            Restaurant r2 = new Restaurant(2)
            {
                RestaurantName = "Itto Sushi",
                FaveDish = "Romeo and Juliet Roll",
                Address = "547 E University Pkwy, Orem, UT 84097",
                PhoneNum = "(385) 497-7045",
                //WebsiteLink = "https://ittoutah.com"
            };

            Restaurant r3 = new Restaurant(3)
            {
                RestaurantName = "Bok Bok Chicken",
                FaveDish = "Boneless House Wings",
                Address = "1181 N Canyon Rd, Provo, UT 84604",
                PhoneNum = "(801) 691-0921",
                WebsiteLink = "https://www.doordash.com/store/bok-bok-provo-provo-906941/en-US/?utm_campaign=gpa"
            };

            Restaurant r4 = new Restaurant(4)
            {
                RestaurantName = "K's Kitchen ",
                FaveDish = "Katsu Curry",
                Address = "322 W Center St, Provo, UT 84601",
                PhoneNum = "(385) 201-7523",
                WebsiteLink = "http://ksjapanesekitchen.com/menu/"
            };

            //This section demonstrates that the default value of the favorite dish section works
            Restaurant r5 = new Restaurant(5)
            {
                RestaurantName = "Joe's Cafe",
                //FaveDish = "Any breakfast food. You literally cannot go wrong",
                Address = "1126 S State St, Orem, UT 84097",
                PhoneNum = "(801) 607-5377",
                WebsiteLink = "http://joescafeorem.com"
            };
            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
