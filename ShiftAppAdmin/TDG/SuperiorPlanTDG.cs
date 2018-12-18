using ShiftAppAdmin.APIClient;
using ShiftAppAdmin.Models;
using ShiftAppAdmin.TDG.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAppAdmin.TDG
{
    class SuperiorPlanTDG : ISuperiorPlanTDG
    {
        public async Task AddSuperiorPlanAsync(SuperiorPlan superiorPlan)
        {
            var client = RefitClient.Service;
            DateTime now = DateTime.UtcNow;
            var nowString = now.ToString("dd/MM/yy HH:mm:ss", CultureInfo.InvariantCulture);
            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                {"owner", superiorPlan.IdOwner},
                {"status", superiorPlan.Status},
                {"created", nowString}
            };

            await client.CreateSuperiorPlan(dict);
        }

        public async Task DeleteSuperiorPlanAsync(SuperiorPlan superiorPlan)
        {
            throw new NotImplementedException();
        }

        public async Task<SuperiorPlan> GetSuperiorPlanByIdAsync(string id)
        {
            var myParams = new MyParams { Query = $"{{\"_id\":\"{id}\"}}" };
            var client = RefitClient.Service;
            var result = await client.GetSuperiorPlan(id);
            SuperiorPlan superiorPlan = new SuperiorPlan
            {
                Id = result.Id,
                Etag = result.Etag,
                Status = result.Status,
                IdShifts = result.IdShifts,
                IdOwner = result.IdOwner,
                Created = result.Created
            };
            return superiorPlan;
        }

        public async Task<List<SuperiorPlan>> GetSuperiorPlansAsync(MyParams myParams)
        {
            var client = RefitClient.Service;
            var result = await client.GetSuperiorPlans(myParams);
            List<SuperiorPlan> superiorPlans = new List<SuperiorPlan>();
            foreach (SuperiorPlan res in result.SuperiorPlans)
            {
                SuperiorPlan sp = new SuperiorPlan
                {
                    Id = res.Id,
                    Etag = res.Etag,
                    Status = res.Status,
                    IdShifts = res.IdShifts,
                    IdOwner = res.IdOwner,
                    Created = res.Created
                };
                superiorPlans.Add(sp);
            }
            return superiorPlans;
        }

        public async Task<SuperiorPlan> GetLatestSuperiorPlanByIdOwner(string idOwner)
        {
            MyParams myParams = new MyParams
            {
                Query = $"{{\"$and\": [{{\"owner\": \"{idOwner}\"}},{{\"status\": \"pending\"}}]}}",
                Limit = "1",
                Sort = "-created"
            };
            List<SuperiorPlan> superiorPlans = await GetSuperiorPlansAsync(myParams);

            if (superiorPlans.Count == 1)
            {
                return superiorPlans[0];
            }
            return null;
        }

        public async Task PatchSuperiorPlanAsync(SuperiorPlan superiorPlan)
        {
            var client = RefitClient.Service;

            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                {"status", superiorPlan.Status}
            };

            client.PatchSuperiorPlan(superiorPlan.Id, dict, superiorPlan.Etag);
        }
    }
}
