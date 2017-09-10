using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using TaxiFareCalculator.Services;
using TaxiFareCalculator.ViewModel;

namespace TaxiFareCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaxiFareService _taxiFareService;
        public HomeController(ITaxiFareService taxiFareService)
        {
            _taxiFareService = taxiFareService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalculateFare(TaxiFareViewModel txFrVM)
        {
            txFrVM.TotalFare = _taxiFareService.CalculateFare(txFrVM);

            var serializer = new JavaScriptSerializer();
            var result = serializer.Serialize(txFrVM);

            return Json(result);
        }
    }
}