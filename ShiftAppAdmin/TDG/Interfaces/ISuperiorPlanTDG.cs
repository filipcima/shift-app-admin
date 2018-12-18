using ShiftAppAdmin.APIClient;
using ShiftAppAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAppAdmin.TDG.Interfaces
{
    interface ISuperiorPlanTDG
    {
        Task<SuperiorPlan> GetSuperiorPlanByIdAsync(string id);
        Task<List<SuperiorPlan>> GetSuperiorPlansAsync(MyParams myParams);
        Task PatchSuperiorPlanAsync(SuperiorPlan superiorPlan);
        Task AddSuperiorPlanAsync(SuperiorPlan superiorPlan);
        Task DeleteSuperiorPlanAsync(SuperiorPlan superiorPlan);
    }
}
