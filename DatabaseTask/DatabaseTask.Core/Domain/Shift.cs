using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Shift
    {
        [Key]
        public int ShiftID { get; set; }

        public int Guards_ID { get; set; }
        public Guards guards { get; set; }

        public int Start_Time { get; set; }

        public int Finish_Time { get; set; }

        public DateTime Date { get; set; }
    }
}
