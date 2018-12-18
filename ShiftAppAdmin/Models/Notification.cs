using Newtonsoft.Json;
using ShiftAppAdmin.TDG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAppAdmin.Models
{
    class Notification
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("_etag")]
        public string Etag { get; set; }

        [JsonProperty("for_users")]
        public List<string> IdForUsers { get; set; }

        [JsonIgnore]
        public List<User> ForUsers { get; set; }

        [JsonProperty("from_user")]
        public string IdFromUser { get; set; }

        [JsonIgnore]
        public User FromUser { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("notification_type")]
        public string NotificationType { get; set; }

        [JsonProperty("show")]
        public bool Show { get; set; }

        [JsonProperty("shift")]
        public string IdShift { get; set; }

        public async Task<Shift> GetShift()
        {
            if (shift == null)
            {
                shift = await new ShiftTDG().GetShiftByIdAsync(IdShift);
            }
            return shift;
        }

        [JsonIgnore]
        private Shift shift;
    }
}
