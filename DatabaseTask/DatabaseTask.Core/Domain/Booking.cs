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
        public Guid? EmployeeId { get; set; }
        public string PaymentMethod { get; set; }
        public float Cost { get; set; }
        public int RoomAmount { get; set; }
        public Guid? GuestId { get; set; }

        public Guests Guests { get; set; }
        public Employee Employee { get; set; }

        public ICollection<Bookable> Bookables { get; set; } = new List<Bookable>();
        public ICollection<ServiceOrder> ServiceOrders { get; set; } = new List<ServiceOrder>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
