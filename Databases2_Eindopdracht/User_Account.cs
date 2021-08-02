using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases2_Eindopdracht
{
    class User_Account
    {
        [Key]
        public int UserId { get; set; }
        public int AccountId { get; set; }
        public string UserName { get; set; }
        public string Photo { get; set; }
        public int Age { get; set; }
        public string Language { get; set; }
        public bool SubtitleSwitch { get; set; }
    }
}
