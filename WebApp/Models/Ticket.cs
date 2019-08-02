using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Ticket
    {
        [Key]
        public int IdTicket { get; set; }
        public TicketType Type { get; set; }
        public DateTime ValidTo { get; set; }

        public ICollection<TicketPrice> TicketPrices { get; set; }

        public Ticket() { }

    }

    public enum TicketType
    {
        OneTime,
        Daily,
        Monthly,
        Yearly
    }
}