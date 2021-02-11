//Parker Mecham, Section 1

using System;
using System.Collections.Generic;

namespace BestRestaurants.Models
{
    public static class TempStorage
    {
        private static List<AddRestaurant> restaurants = new List<AddRestaurant>();

        public static IEnumerable<AddRestaurant> Restaurants => restaurants;

        public static void AddRestaurant(AddRestaurant restaurant)
        {
            restaurants.Add(restaurant);
        }
    }
}
