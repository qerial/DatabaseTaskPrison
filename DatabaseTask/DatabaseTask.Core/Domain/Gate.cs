using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Gate
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? TerminalID { get; set; }
        public int GateNr { get; set; }
        public int MaxPlaneSize { get; set; }
        public string Location { get; set; }
        public Terminal Terminal { get; set; }
    }
}
