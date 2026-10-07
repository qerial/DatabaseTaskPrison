using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Position { get; set; }
        public int TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PersonalId { get; set; }
        public Guid? HotelId { get; set; }

        public Hotel Hotel { get; set; }

        public ICollection<Payroll> Payrolls { get; set; } = new List<Payroll>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();

    }
}
