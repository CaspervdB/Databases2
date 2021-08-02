using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases2_Eindopdracht
{
    class Wrong_Attempt
    {
        [Key]
        public int AttemptId { get; set; }
        public DateTime Date { get; set; }
        public int AccountId { get; set; }
        public int Attempt { get; set; }
    }
}
