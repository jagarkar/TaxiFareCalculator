using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaxiFareCalculator.ViewModel;

namespace TaxiFareCalculator.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void  CalculateFare(TaxiFareViewModel txFrVM)
        {
            var t = 0;
        }

    }
}