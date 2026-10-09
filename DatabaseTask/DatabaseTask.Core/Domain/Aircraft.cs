using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Aircraft
    {
        [Key]
        public Guid Id { get; set; }
        public int RegistrationNumber { get; set; }
        public string Model { get; set; }
        public int Seats { get; set; }
        public DateTime YearOfManufacture { get; set; }
        public ICollection<Flight> Flight { get; set; } = new List<Flight>();

    }
}
