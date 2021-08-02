using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases2_Eindopdracht
{
    class Subscription
    {
        [Key]
        public int SubscriptionId { get; set; }
        public string TypeSubscription { get; set; }
        public int Price { get; set; }
    }
}
