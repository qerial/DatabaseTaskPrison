using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Baggage
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? PassangerID { get; set; }
        public Guid? BaggageTypeID { get; set; }
        public Guid? FlightID { get; set; }
        public int Number { get; set; }
        public int Weight { get; set; }
        public ICollection<Passenger> Passengers { get; set; } = new List<Passenger>();
    }
}
