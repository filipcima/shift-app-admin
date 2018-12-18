using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAppAdmin.Models
{
    class SuperiorPlanList
    {
        [JsonProperty("_items")]
        public List<SuperiorPlan> SuperiorPlans { get; set; }
    }
}
