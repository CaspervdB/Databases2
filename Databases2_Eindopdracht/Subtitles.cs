using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases2_Eindopdracht
{
    class Subtitles
    {
        [Key]
        public int SubtitleId { get; set; }
        public int TitleId { get; set; }
        public string Language { get; set; }
    }
}
