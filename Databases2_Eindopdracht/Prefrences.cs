using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases2_Eindopdracht
{
    class Prefrences
    {
        [Key]
        public int GenreId { get; set; }
        public int AccountId { get; set; }
        public string ViewingGuide { get; set; }
    }
}
