using Newtonsoft.Json;
using ShiftAppAdmin.TDG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShiftAppAdmin.Models
{
    class SuperiorPlan
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("_etag")]
        public string Etag { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("owner")]
        public string IdOwner { get; set; }

        public async Task<User> GetOwner()
        {
            if (owner == null)
            {
                owner = await new UserTDG().GetUserByIdAsync(IdOwner);
            }

            return owner;
        }

        [JsonIgnore]
        private User owner;

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("shifts")]
        public List<string> IdShifts { get; set; }

        public async Task<List<Shift>> GetShifts()
        {
            if (shifts == null)
            {
                shifts = new List<Shift>();
                foreach (string id in IdShifts)
                {
                    Shift shift = await new ShiftTDG().GetShiftByIdAsync(id);
                    shifts.Add(shift);
                }
            }
            return shifts;
        }

        [JsonIgnore]
        private List<Shift> shifts;
    }
}
