using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Registration
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? FlightID { get; set; }
        public Guid? PassengerID { get; set; }
        public int SeatNr { get; set; }
        public int TicketType { get; set; }
        public DateTime RegistrationDate { get; set; }
        public ICollection<Flight> Flight { get; set; } = new List<Flight>();
        public Passenger Passenger { get; set; }
    }
}
