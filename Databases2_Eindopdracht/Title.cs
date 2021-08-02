using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases2_Eindopdracht
{
    class Title
    {
        [Key]
        public int TitleId { get; set; }
        public string Name { get; set; }
        public int duration { get; set; }
        public int ViewingGuide { get; set; }
        public int CreditsTime { get; set; }
        public string Quality { get; set; }
        public string Type { get; set; }
    }
}
