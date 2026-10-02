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
        public float Ammount { get; set; }
        public string PaymentMethod { get; set; }
        public Guests Guests { get; set; }
        public Employee Employee { get; set; }
        public Booking Booking { get; set; }
    }
}
