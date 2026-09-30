using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Visitors
    {
        [Key]
        public int VisitorID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public int PersonalNumber { get; set; }
        public int TelephoneNumber { get; set; }
        public string relation_to_the_prisoner { get; set; }

        public int VisitID { get; set; }
        [ForeignKey(nameof(VisitID))]
        public Visit Visit { get; set; } = null!;

        public ICollection<Prisoners> Prisoners { get; set; } = new List<Prisoners>();
    }
}
