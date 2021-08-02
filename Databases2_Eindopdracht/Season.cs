using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases2_Eindopdracht
{
    class Season
    {
        [Key]
        public int SeasonId { get; set; }
        public string Name { get; set; }
        public int NumberOfEpisodes { get; set; }
    }
}
