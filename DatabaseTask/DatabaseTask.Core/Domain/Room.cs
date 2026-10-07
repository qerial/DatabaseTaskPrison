using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Room
    {
        [Key]
        public Guid Id { get; set; }
        public string RoomType { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int RoomNr { get; set; }
        public int Floor { get; set; }
        public bool AirCon { get; set; }
        public string Description { get; set; }

        public ICollection<Bookable> Bookables { get; set; } = new List<Bookable>();
    }
}
