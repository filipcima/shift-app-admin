using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAppAdmin.Models
{
    class NotificationList
    {
        [JsonProperty("_items")]
        public List<Notification> Notifications { get; set; }
    }
}
