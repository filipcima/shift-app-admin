using ShiftAppAdmin.Models;
using ShiftAppAdmin.APIClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ShiftAppAdmin.TDG.Interfaces;

namespace ShiftAppAdmin.TDG
{
    class UserTDG : IUserTDG
    {
        public async Task AddUserAsync(User user)
        {
            var client = RefitClient.Service;
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("firstname", user.Firstname);
            dict.Add("lastname", user.Secondname);
            dict.Add("superior", user.IdSuperiorUser);
            dict.Add("role", user.Role);
            dict.Add("password_hash", user.PasswordHash);
            dict.Add("mail", user.Mail);
            client.CreateUser(dict);
        }

        public async Task DeleteUserAsync(User user)
        {
            var client = RefitClient.Service;
            client.DeleteUser(user.Id, user.Etag);
        }

        public async Task<User> GetUserByIdAsync(string id)
        {
            var myParams = new MyParams { Query = $"{{\"_id\":\"{id}\"}}" };
            var client = RefitClient.Service;
            var result = await client.GetUser(id);
            User user = new User
            {
                Id = result.Id,
                Etag = result.Etag,
                Firstname = result.Firstname,
                Secondname = result.Secondname,
                IdSuperiorUser = result.IdSuperiorUser,
                Mail = result.Mail,
                PasswordHash = result.PasswordHash,
                Role = result.Role,
            };
            return user;
        }

        public async Task<List<User>> GetUsersAsync(MyParams myParams)
        {
            var client = RefitClient.Service;
            var result = await client.GetUsers(myParams);
            List<User> users = new List<User>();
            foreach (User res in result.Users)
            {
                User user = new User
                {
                    Id = res.Id,
                    Etag = res.Etag,
                    Firstname = res.Firstname,
                    Secondname = res.Secondname,
                    IdSuperiorUser = res.IdSuperiorUser,
                    Mail = res.Mail,
                    PasswordHash = res.PasswordHash,
                    Role = res.Role,

                };
                users.Add(user);
            }
            return users;
        }

        public async Task<List<User>> GetInferiorsAsync(String idSuperior)
        {
            MyParams myParams = new MyParams
            {
                Query = $"{{\"superior\":\"{idSuperior}\"}}"
            };
            List<User> inferiors = await GetUsersAsync(myParams);
            return inferiors;
        }

        public Task PatchUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
