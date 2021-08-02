using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases2_Eindopdracht
{
    class Watchlist
    {
        [Key]
        public int WatchlistId { get; set; }
        public int UserId { get; set; }
        public int TitleId { get; set; }
        public bool TitleWatched { get; set; }
    }
}
