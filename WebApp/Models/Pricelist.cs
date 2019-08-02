using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Pricelist
    {
        [Key]
        public int IdPricelist { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public ICollection<TicketPrice> TicketPrices { get; set; }

        public Pricelist() { }
    }
}