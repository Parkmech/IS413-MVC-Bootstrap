//Parker Mecham, Section 1


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BestRestaurants.Models;

namespace BestRestaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //HOME PAGE
        public IActionResult Index()
        {
            List<string> RestaurantList = new List<string>();

            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                r.FaveDish ??= "It's all tasty!";
                r.WebsiteLink ??= "Coming Soon!";

                RestaurantList.Add(string.Format("#{0}: {1} <br>Best Dish: {2} <br>Address: {3} " +
                    "<br>Phone Number: {4} <br> <a href=\"{5}\">{5}</a><br><br>",
                    r.RestaurantRank, r.RestaurantName, r.FaveDish, r.Address, r.PhoneNum, r.WebsiteLink));
            }

            return View(RestaurantList);
        }

        //ADD RESTAURANT PAGE WHEN YOU CLICK THE LINK
        [HttpGet]
        public IActionResult AddRestaurant()
        {
            return View();
        }

        //SENDS YOU TO THE CONFIRMATION IF THE MODEL IS CORRECT, OTHERWISE IT RELOADS THE ADD RESTAURANT PAGE
        [HttpPost]
        public IActionResult AddRestaurant(AddRestaurant addRestaurant)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddRestaurant(addRestaurant);
                return View("Confirmation", addRestaurant);
            }
            else return View("AddRestaurant");
        }

        //THE USER SUGGESTED RESTAURANTS 
        public IActionResult SuggestedRestaurants()
        {

            List<string> RestaurantList = new List<string>();

            foreach (AddRestaurant aR in TempStorage.Restaurants)
            {
    
                
                RestaurantList.Add(string.Format("User Name: {0} <br> Restaurant Name: {1} <br> Best Dish: {2} " +
                    "<br>Restaurant Phone Number: {3}",
                    aR.UserName, aR.RestaurantName, aR.FaveDish, aR.PhoneNum));
            }
            return View(RestaurantList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
