using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Booking
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int PeopleCount { get; set; }
        public string PaymentMethod { get; set; }
        public string RoomAmmount { get; set; }
        public Employee Employee { get; set; }
        public Guests Guests { get; set; }
    }
}
