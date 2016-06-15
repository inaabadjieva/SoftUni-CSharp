using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_Ratings.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult DrawRating(int rating)
        {
            ViewBag.Rating = "Rating: " + rating;
            var fullStarsCount = rating *10/ 100;
            var emptyStarsCount = (100-rating)*10/100;
            var halfStarsCount = 10 - fullStarsCount - emptyStarsCount;

            string stars = "";
            for (int i= 0; i< fullStarsCount; i++)
            stars += "<img src = '/images/1456238577_star-4.png'/>";
            for (int i= 0; i< halfStarsCount; i++)
            stars += "<img src = '/images/1456238660_star-2.png'/>";
            for (int i= 0; i< emptyStarsCount; i++)
                stars += "<img src = '/images/1456238564_star-0.png'/>";
            ViewBag.Stars = stars;


            return View("Index","",stars);
        }
    }
}