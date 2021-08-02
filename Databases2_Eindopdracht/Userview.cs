using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases2_Eindopdracht
{
    class Userview
    {
        [Key]
        public int ViewId { get; set; }
        public int UserId { get; set; }
        public int EpisodeId { get; set; }
        public bool TitlePaused { get; set; }
        public int TimePaused { get; set; }
        public bool SubtitleSwitch { get; set; }
        public string SubtitleLanguage { get; set; }
        public string Language { get; set; }
        public bool TitleFinished { get; set; }
        public DateTime dateTime { get; set; }
        public int Duration { get; set; }
    }
}
