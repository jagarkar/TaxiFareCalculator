using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiFareCalculator.ViewModel;

namespace TaxiFareCalculator.Tests.Fakes
{
    public static class FakeTaxiFareViewModel
    {
        public static TaxiFareViewModel StandardRide()
        {
            TaxiFareViewModel txFareVMtest = new TaxiFareViewModel();
            txFareVMtest.RideStartDateTime = new DateTime(2010, 10, 08, 9, 30, 0);
            txFareVMtest.NumberOfMilesDrivenBelow6mph = 2;
            txFareVMtest.NumberOfMinutesDrivenAbove6mph = 5;

            return txFareVMtest;
        }
        public static TaxiFareViewModel NightSurchargeRide()
        {
            TaxiFareViewModel txFareVMtest = new TaxiFareViewModel();
            txFareVMtest.RideStartDateTime = new DateTime(2010, 10, 08, 20, 30, 0);
            txFareVMtest.NumberOfMilesDrivenBelow6mph = 2;
            txFareVMtest.NumberOfMinutesDrivenAbove6mph = 5;

            return txFareVMtest;
        }

        public static TaxiFareViewModel WeekdayPeakSurchargeRide()
        {
            TaxiFareViewModel txFareVMtest = new TaxiFareViewModel();
            txFareVMtest.RideStartDateTime = new DateTime(2010, 10, 08, 16, 30, 0);
            txFareVMtest.NumberOfMilesDrivenBelow6mph = 2;
            txFareVMtest.NumberOfMinutesDrivenAbove6mph = 5;

            return txFareVMtest;
        }
    }
}
