using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Vehicles
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public int LineId { get; set; }
        public Line Line { get; set; }
        public Vehicles() { }
    }
}