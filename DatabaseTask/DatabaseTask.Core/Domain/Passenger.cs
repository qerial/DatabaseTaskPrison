using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Passenger
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? RegistrationID { get; set; }
        public DateTime DOB { get; set; }
        public int IdentityCard { get; set; }
        public int PhoneNr { get; set; }
        public string Email { get; set; }
        public ICollection<Registration> Registration { get; set; } = new List<Registration>();
        public ICollection<BaggageType> BaggageType { get; set; } = new List<BaggageType>();
        public Baggage Baggage { get; set; }
    }
}
