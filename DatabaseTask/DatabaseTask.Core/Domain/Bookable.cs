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
        public string Status { get; set; }
        public Booking Booking { get; set; }
        public Room Room { get; set; }
    }
}
