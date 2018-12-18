using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAppAdmin.Models
{
    class UserList
    {
        [JsonProperty("_items")]
        public List<User> Users { get; set; }
    }
}
