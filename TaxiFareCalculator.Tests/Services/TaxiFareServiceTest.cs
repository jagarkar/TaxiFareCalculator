using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxiFareCalculator.Services;
using TaxiFareCalculator.ViewModel;
using TaxiFareCalculator.Tests.Fakes;

namespace TaxiFareCalculator.Tests.Services
{
    [TestClass]
    public class TaxiFareServiceTest
    {
        private  TaxiFareService _taxiFareService;

        [TestInitialize]
        public void Init()
        {
            _taxiFareService = new TaxiFareService();
        }
        [TestMethod]
        public void TestTaxiStandardRideTotalFare()
        {           
           decimal totalFare = 
                _taxiFareService.CalculateFare(FakeTaxiFareViewModel.StandardRide());

            Assert.IsTrue(totalFare == 8.75m);
        }

        [TestMethod]
        public void TestTaxiNightSurchargeRideTotalFare()
        {
            decimal totalFare =
                 _taxiFareService.CalculateFare(FakeTaxiFareViewModel.NightSurchargeRide());

            Assert.IsTrue(totalFare == 9.25m);
        }

        [TestMethod]
        public void TestTaxiWeekdayPeakSurchargeRideTotalFare()
        {
            decimal totalFare =
                 _taxiFareService.CalculateFare(FakeTaxiFareViewModel.WeekdayPeakSurchargeRide());

            Assert.IsTrue(totalFare == 9.75m);
        }
    }
}
