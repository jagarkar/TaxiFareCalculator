using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiFareCalculator.Utility
{
    public static class TaxiFareConstants
    {
        public const decimal BaseFare = 3;
        public const decimal NYtaxSurchargeRate = (decimal)0.5;
        public const decimal NightSurchargeRate = (decimal)0.5;
        public const decimal WeekDayPeakHourSurchargeRate = 1;
        public const decimal UnitFare = (decimal)0.35;
        public static TimeSpan NightSurchargeStartTime = new TimeSpan(20, 0, 0);
        public static TimeSpan NightSurchargeEndTime = new TimeSpan(6, 0, 0);
        public static TimeSpan WeekDayPeakHourStartTime = new TimeSpan(16, 0, 0);
        public static TimeSpan WeekDayPeakHourEndTime = new TimeSpan(20, 0, 0);
        public const decimal MilesPerUnitFare = (decimal)0.2;
        public const decimal MinutesPerUnitFare = 1;
    }
}