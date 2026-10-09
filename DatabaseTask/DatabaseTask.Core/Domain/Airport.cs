using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Airport
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public Flight Flight { get; set; }
        public ICollection<Terminal> Terminal { get; set; } = new List<Terminal>();

    }
}
