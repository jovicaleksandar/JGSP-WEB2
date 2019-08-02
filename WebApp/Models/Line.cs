using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Line
    {
        public int Id { get; set; }
        public int LineNumber { get; set; }
        public ICollection<Station> Stations { get; set; }
        public ICollection<Timetable> Timetables { get; set; }
        public ICollection<Vehicles> Vehicles { get; set; }

        public Line() { }
    }
}