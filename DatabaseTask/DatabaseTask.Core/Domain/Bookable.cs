using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Bookable
    {
        [Key]
        public Guid Id { get; set; }
        public string ExtraInfo { get; set; }
        public int Status { get; set; }
        public Guid? BookingId { get; set; }
        public Guid? RoomId { get; set; }

        public Room Room { get; set; }
        public Booking Booking { get; set; }
    }
}
