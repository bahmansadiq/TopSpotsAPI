using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopSpotWeb.Models
{

    public class TopSpot
    {
        public string name { get; set; }
        public string description { get; set; }
        public double [] location { get; set; }
        // public IList<double> location { get; set; }
    }

    //public class Example
    //{
    //    public IList<TopSpot> topSpots { get; set; }
    //}
}