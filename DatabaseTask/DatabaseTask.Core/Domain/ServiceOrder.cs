using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class ServiceOrder
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? ServicesId { get; set; }
        public Guid? BookingId { get; set; }
        public DateTime Date { get; set; }

        public Booking Booking { get; set; }
        public Services Services { get; set; }
    }
}
