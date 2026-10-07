using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Payment
    {
        [Key]
        public Guid Id { get; set; }
        public float PaymentDate { get; set; }
        public float Amount { get; set; }
        public string PaymentMethod { get; set; }
        public Guid? EmployeeId { get; set; }
        public Guid? GuestId { get; set; }
        public Guid? PayerID { get; set; }
        public Guid? BookingId { get; set; }

        public Booking Booking { get; set; }
        public Employee Employee { get; set; }

        public ICollection<Guests> Guests { get; set; } = new List<Guests>();
    }
}
