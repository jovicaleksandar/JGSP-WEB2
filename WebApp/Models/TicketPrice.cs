using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class TicketPrice
    {
        [Key]
        public int IdTicketPrice { get; set; }
        public float Price { get; set; }

        [ForeignKey("Pricelist")]
        public int PricelistId { get; set; }
        public Pricelist Pricelist {get; set;}
        [ForeignKey("Ticket")]
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }

        public TicketPrice() { }

    }
}