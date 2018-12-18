using Newtonsoft.Json;
using ShiftAppAdmin.APIClient;
using ShiftAppAdmin.Models;
using ShiftAppAdmin.TDG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAppAdmin.TDG
{
    class NotificationTDG : INotificationTDG
    {
        public async Task AddNotificationAsync(Notification notification)
        {
            var client = RefitClient.Service;
            
            
            Dictionary<string, object> dict = new Dictionary<string, object>();

            dict.Add("for_users", notification.IdForUsers);
            dict.Add("from_user", notification.IdFromUser);
            dict.Add("message", notification.Message);
            dict.Add("notification_type", notification.NotificationType);
            dict.Add("show", true);
            dict.Add("shift", notification.IdShift);

            client.CreateNotification(dict);

            /*
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://192.168.2.103:5000/notifications");
            try
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("", content);
                var result = await response.Content.ReadAsStringAsync();

            }
            catch (Exception er)
            {
                var lb = er.ToString();
            }
            */

        }

        public async Task DeleteNotificationAsync(Notification notification)
        {
            throw new NotImplementedException();
        }

        public async Task<Notification> GetNotificationByIdAsync(string id)
        {
            var myParams = new MyParams { Query = $"{{\"_id\":\"{id}\"}}" };
            var client = RefitClient.Service;
            var result = await client.GetNotification(id);
            Notification notification = new Notification
            {
                Id = result.Id,
                Etag = result.Etag,
                IdForUsers = result.IdForUsers,
                IdShift = result.IdShift,
                IdFromUser = result.IdFromUser,
                Message = result.Message,
                NotificationType = result.NotificationType,
                Show = result.Show
            };
            return notification;
        }

        public async Task<List<Notification>> GetNotificationsAsync(MyParams myParams)
        {
            var client = RefitClient.Service;
            var result = await client.GetNotifications(myParams);
            List<Notification> notifications = new List<Notification>();
            foreach (Notification res in result.Notifications)
            {
                Notification notification = new Notification
                {
                    Id = res.Id,
                    Etag = res.Etag,
                    IdForUsers = res.IdForUsers,
                    IdShift = res.IdShift,
                    IdFromUser = res.IdFromUser,
                    Message = res.Message,
                    NotificationType = res.NotificationType,
                    Show = res.Show
                };
                notifications.Add(notification);
            }
            return notifications;
        }

        public async Task PatchNotificationAsync(Notification notification)
        {
            throw new NotImplementedException();
        }
    }
}
