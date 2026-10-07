using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Hotel
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RoomAmount { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
