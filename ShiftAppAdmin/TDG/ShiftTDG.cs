using ShiftAppAdmin.APIClient;
using ShiftAppAdmin.Models;
using ShiftAppAdmin.TDG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAppAdmin.TDG
{
    class ShiftTDG : IShiftTDG
    {
        public async Task AddShiftAsync(Shift shift)
        {
            var client = RefitClient.Service;
            
            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                { "superior_plan", shift.IdSuperiorPlan },
                { "date_from", shift.DateFrom },
                { "date_to", shift.DateTo },
                { "number_of_workers", shift.WorkersCount },
                { "workers", new List<string>() }
            };

            await client.CreateShift(dict);
        }

        public async Task DeleteShiftAsync(Shift shift)
        {
            var client = RefitClient.Service;
            Shift deletedShift = await GetShiftByIdAsync(shift.Id);
            await client.DeleteShift(deletedShift.Id, deletedShift.Etag);
        }

        public async Task<Shift> GetShiftByIdAsync(string id)
        {
            var myParams = new MyParams { Query = $"{{\"_id\":\"{id}\"}}" };
            var client = RefitClient.Service;
            var result = await client.GetShift(id);
            Shift shift = new Shift
            {
                Id = result.Id,
                Etag = result.Etag,
                DateFrom = result.DateFrom,
                DateTo = result.DateTo,
                WorkersCount = result.WorkersCount,
                IdSuperiorPlan = result.IdSuperiorPlan,
                IdWorkers = result.IdWorkers,
            };
            return shift;
        }

        public async Task<List<Shift>> GetShiftsAsync(MyParams myParams)
        {
            var client = RefitClient.Service;
            var result = await client.GetShifts(myParams);
            List<Shift> shifts = new List<Shift>();
            foreach (Shift res in result.Shifts)
            {
                Shift shift = new Shift
                {
                    Id = res.Id,
                    Etag = res.Etag,
                    DateFrom = res.DateFrom,
                    DateTo = res.DateTo,
                    WorkersCount = res.WorkersCount,
                    IdSuperiorPlan = res.IdSuperiorPlan,
                    IdWorkers = res.IdWorkers,
                };
                shifts.Add(shift);
            }
            return shifts;
        }

        public async Task<List<Shift>> GetShiftsByIdSuperiorPlanAsync(string idPlan)
        {
            MyParams myParams = new MyParams
            {
                Query = $"{{\"superior_plan\": \"{idPlan}\"}}",
                Sort = "date_from"
            };
            List<Shift> shifts = await GetShiftsAsync(myParams);

            return shifts;
        }

        public async Task<Shift> GetNextShift(MyParams myParams = null)
        {
            if (myParams == null)
            {
                DateTime now = DateTime.Now;
                StringBuilder dateNow = new StringBuilder();
                dateNow.Append(now.Day);
                dateNow.Append("/");
                dateNow.Append(now.Month);
                dateNow.Append("/");
                dateNow.Append(now.Year.ToString().Substring(2));
                dateNow.Append(" ");
                dateNow.Append(now.Hour);
                dateNow.Append(":");
                dateNow.Append(now.Minute);
                dateNow.Append(":");
                dateNow.Append(now.Second);

                String nowString = dateNow.ToString();
                
                myParams = new MyParams
                {
                    Query = $"{{\"date_from\":{{\"$gt\":\"{nowString}\"}}}}",
                    Limit = "1",
                    Sort = "-date_to"
                };
            }

            List<Shift> shifts = await GetShiftsAsync(myParams);

            if (shifts[0] != null)
            {
                return shifts[0];
            }

            return null;
        }

        public async Task PatchShiftAsync(Shift shift)
        {
            var client = RefitClient.Service;

            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                {"workers", shift.IdWorkers}
            };

            client.PatchShift(shift.Id, dict, shift.Etag);
        }
    }
}
