using ShiftAppAdmin.APIClient;
using ShiftAppAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAppAdmin.TDG.Interfaces
{
    interface IUserTDG
    {
        Task<User> GetUserByIdAsync(string id);
        Task<List<User>> GetUsersAsync(MyParams myParams);
        Task AddUserAsync(User user);
        Task PatchUserAsync(User user);
        Task DeleteUserAsync(User user);
    }
}
