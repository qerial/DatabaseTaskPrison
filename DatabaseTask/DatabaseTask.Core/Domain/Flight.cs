using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Flight
    {
        [Key] 
        public Guid Id { get; set; }
        public Guid? AircraftID { get; set; }
        public int FlightNr { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public ICollection<Airport> Airport { get; set; } = new List<Airport>();
        public FlightStatus FlightStatus { get; set; }
        public Airline Airline { get; set; }
        public Aircraft Aircraft { get; set; }
        public ICollection<Registration> Registration { get; set; } = new List<Registration>();


    }
}
