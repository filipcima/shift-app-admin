using Newtonsoft.Json;
using ShiftAppAdmin.TDG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAppAdmin.Models
{
    class User
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("_etag")]
        public string Etag { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Secondname { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("password_hash")]
        public string PasswordHash { get; set; }

        [JsonProperty("superior")]
        public string IdSuperiorUser { get; set; }

        public async Task<User> GetSuperiorUser()
        {
            if (superiorUser == null)
            {
                superiorUser = await new UserTDG().GetUserByIdAsync(IdSuperiorUser);
            }

            return superiorUser;
        }

        [JsonIgnore]
        private User superiorUser;
    }
}
