using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaxiFareCalculator.Utility;
using TaxiFareCalculator.ViewModel;

namespace TaxiFareCalculator.Services
{
    public class TaxiFareService : ITaxiFareService
    {
        public decimal CalculateFare(TaxiFareViewModel txVM)
        {


            decimal totalFare = TaxiFareConstants.BaseFare + TaxiFareConstants.NYtaxSurchargeRate +
                TaxiFareConstants.UnitFare * (txVM.NumberOfMilesDrivenBelow6mph / TaxiFareConstants.MilesPerUnitFare +
                txVM.NumberOfMinutesDrivenAbove6mph / TaxiFareConstants.MinutesPerUnitFare) +
                NightSurcharge(txVM.RideStartDateTime.TimeOfDay) + WeekDayPeakHourSurcharge(txVM.RideStartDateTime, txVM.RideStartDateTime.TimeOfDay);

            return totalFare;
        }

        
        private decimal NightSurcharge(TimeSpan rideStartTime)
        {

            if (rideStartTime >= TaxiFareConstants.NightSurchargeStartTime
                || rideStartTime < TaxiFareConstants.NightSurchargeEndTime)
            { return TaxiFareConstants.NightSurchargeRate; }

            return 0;
        }

        private decimal WeekDayPeakHourSurcharge(DateTime rideStartDate ,TimeSpan rideStartTime)
        {
            if (rideStartDate.DayOfWeek != DayOfWeek.Saturday && rideStartDate.DayOfWeek != DayOfWeek.Sunday)
            {
                if (rideStartTime >= TaxiFareConstants.WeekDayPeakHourStartTime
                && rideStartTime < TaxiFareConstants.WeekDayPeakHourEndTime)
                {
                    return TaxiFareConstants.WeekDayPeakHourSurchargeRate;
                }
            }

            return 0;
        }
            
            
    }
}