using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Airline
    {
        [Key]
        public Guid Id { get; set; }
        public string AirlineName { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string PhoneNr { get; set; }
        public ICollection<Flight> Flight { get; set; } = new List<Flight>();



    }
}
