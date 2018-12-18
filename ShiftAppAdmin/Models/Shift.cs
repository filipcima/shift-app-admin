using Newtonsoft.Json;
using ShiftAppAdmin.APIClient;
using ShiftAppAdmin.TDG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAppAdmin.Models
{
    class Shift
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("_etag")]
        public string Etag { get; set; }

        [JsonProperty("date_from")]
        public string DateFrom { get; set; }

        [JsonProperty("date_to")]
        public string DateTo { get; set; }

        [JsonProperty("number_of_workers")]
        public int WorkersCount { get; set; }

        [JsonProperty("superior_plan")]
        public string IdSuperiorPlan { get; set; }

        public async Task<SuperiorPlan> GetSuperiorPlan()
        {
            if (superiorPlan == null)
            {
                superiorPlan = await new SuperiorPlanTDG().GetSuperiorPlanByIdAsync(IdSuperiorPlan);
            }

            return superiorPlan;
        }

        [JsonIgnore]
        private SuperiorPlan superiorPlan;

        [JsonProperty("workers")]
        public List<string> IdWorkers { get; set; }

        public async Task<List<User>> GetWorkers()
        {
            if (workers == null && IdWorkers != null)
            {
                workers = new List<User>();
                
                foreach (string id in IdWorkers)
                {
                    User user = await new UserTDG().GetUserByIdAsync(id);
                    workers.Add(user);
                }
            }
            return workers;
        }

        [JsonIgnore]
        private List<User> workers;
    }
}
