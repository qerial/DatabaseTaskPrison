using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Payroll
    {
        [Key]
        public Guid Id { get; set; }
        public float Sum { get; set; }
        public DateTime Date  { get; set; }
        public Employee Employee { get; set; }
    }
}
