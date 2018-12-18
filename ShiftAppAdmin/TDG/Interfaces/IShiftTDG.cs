using ShiftAppAdmin.APIClient;
using ShiftAppAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAppAdmin.TDG.Interfaces
{
    interface IShiftTDG
    {
        Task<Shift> GetShiftByIdAsync(string id);
        Task<List<Shift>> GetShiftsAsync(MyParams myParams);
        Task PatchShiftAsync(Shift shift);
        Task AddShiftAsync(Shift shift);
        Task DeleteShiftAsync(Shift shift);
    }
}
