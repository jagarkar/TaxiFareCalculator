using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiFareCalculator.ViewModel
{
    public class TaxiFareViewModel
    {
        public decimal NumberOfMilesDrivenBelow6mph { get; set; }
        public decimal NumberOfMinutesDrivenAbove6mph { get; set; }
        //public DateTime RideStartDate { get; set; }
        //public TimeSpan RideStartTime { get; set; }
        public DateTime RideStartDateTime { get; set; }
        public string RideStartLocation { get; set; }
        public string RideEndLocation { get; set; }
        public decimal TotalFare { get; set; }

    }
}