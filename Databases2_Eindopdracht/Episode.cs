using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases2_Eindopdracht
{
    class Episode
    {
        [Key]
        public int EpisodeId { get; set; }
        public int TitleId { get; set; }
        public string name { get; set; }
        public int Duration { get; set; }
    }
}
