using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class FlightStatus
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? FlightID { get; set; }
        public string StatusChange { get; set; }
        public DateOnly ChangeTime { get; set; }
        public string ChangeReason { get; set; }
        public Flight flight { get; set; }
    }
}
