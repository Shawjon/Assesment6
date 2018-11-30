using Assesment6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assesment6.App_Start.Controllers
{
    public class RSVPController : Controller
    {
        // GET: RSVP
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RSVP()
        {
            return View();
        }
        public ActionResult Summary(Person person)
        {
            return View(person);
        }
        public ActionResult Dish()
        {
            return View();
        }
        public ActionResult DishSummary(Dish dish)
        {
            return View(dish);
        }
    }
}