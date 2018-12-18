using ShiftAppAdmin.APIClient;
using ShiftAppAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAppAdmin.TDG.Interfaces
{
    interface INotificationTDG
    {
        Task<Notification> GetNotificationByIdAsync(string id);
        Task<List<Notification>> GetNotificationsAsync(MyParams myParams);
        Task PatchNotificationAsync(Notification notification);
        Task AddNotificationAsync(Notification notification);
        Task DeleteNotificationAsync(Notification notification);
    }
}
