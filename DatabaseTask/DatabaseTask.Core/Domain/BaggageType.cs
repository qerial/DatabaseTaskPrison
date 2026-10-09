using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class BaggageType
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? PassangerID { get; set; }
        public Guid? FlightID { get; set; }
        public Passenger Passenger { get; set; }
    }
}
