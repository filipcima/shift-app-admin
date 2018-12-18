using ShiftAppAdmin.APIClient;
using ShiftAppAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAppAdmin.TDG.Interfaces
{
    interface IRequestTDG
    {
        Task<Request> GetRequestByIdAsync(string id);
        Task<List<Request>> GetRequestsAsync(MyParams myParams);
        Task AddRequestAsync(Request request);
        Task PatchRequestAsync(Request request);
        Task DeleteRequestAsync(Request request);
    }
}
