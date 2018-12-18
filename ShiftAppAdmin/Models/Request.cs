using Newtonsoft.Json;
using ShiftAppAdmin.TDG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAppAdmin.Models
{
    class Request
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("_etag")]
        public string Etag { get; set; }

        [JsonProperty("created_by")]
        public string IdCreatedBy { get; set; }

        
        public async Task<User> GetCreatedBy()
        {
            if (createdBy == null)
            {
                createdBy = await new UserTDG().GetUserByIdAsync(IdCreatedBy);
            }

            return createdBy;
        }

        [JsonIgnore]
        private User createdBy;

        [JsonProperty("for_shift")]
        public string IdForShift { get; set; }

        public async Task<Shift> GetShift()
        {
            if (forShift == null)
            {
                forShift = await new ShiftTDG().GetShiftByIdAsync(IdForShift);
            }
            return forShift;
        }

        [JsonIgnore]
        private Shift forShift;

        [JsonProperty("request_type")]
        public string RequestType { get; set; }

        [JsonProperty("accepted")]
        public bool Accepted { get; set; }

        [JsonProperty("resolved")]
        public bool Resolved { get; set; }
    }
}
