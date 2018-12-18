using Refit;
using ShiftAppAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAppAdmin.APIClient
{
    interface IShiftAppService
    {
        // PEOPLE 
        [Get("/people/{mail}")]
        Task<User> GetUser(string mail);

        [Get("/people")]
        Task<UserList> GetUsers([Query()] MyParams myParams);

        [Post("/people")]
        [Headers("Content-Type: application/json; charset=UTF-8")]
        Task CreateUser([Body] Dictionary<string, object> obj);

        [Patch("/people/{mail}")]
        Task PatchUser(string mail, [Body] Dictionary<string, object> obj, [Header("If-Match")] string etag);

        [Delete("/people/{mail}")]
        Task DeleteUser(string mail, [Header("If-Match")] string etag);

        // SHIFTS
        [Get("/shifts/{id}")]
        Task<Shift> GetShift(string id);

        [Get("/shifts")]
        Task<ShiftList> GetShifts([Query()] MyParams myParams);

        [Post("/shifts")]
        [Headers("Content-Type: application/json; charset=UTF-8")]
        Task CreateShift([Body] Dictionary<string, object> obj);

        [Patch("/shifts/{id}")]
        Task PatchShift(string id, [Body] Dictionary<string, object> obj, [Header("If-Match")] string etag);

        [Delete("/shifts/{id}")]
        Task DeleteShift(string id, [Header("If-Match")] string etag);


        // SUPERIOR PLANS
        [Get("/superior_plans/{id}")]
        Task<SuperiorPlan> GetSuperiorPlan(string id);

        [Get("/superior_plans")]
        Task<SuperiorPlanList> GetSuperiorPlans([Query()] MyParams myParams);

        [Post("/superior_plans")]
        [Headers("Content-Type: application/json; charset=UTF-8")]
        Task CreateSuperiorPlan([Body] Dictionary<string, object> obj);

        [Patch("/superior_plans/{id}")]
        Task PatchSuperiorPlan(string id, [Body] Dictionary<string, object> obj, [Header("If-Match")] string etag);

        [Delete("/superior_plans/{id}")]
        Task DeleteSuperiorPlan(string id, [Header("If-Match")] string etag);


        // REQUESTS
        [Get("/requests/{id}")]
        Task<Request> GetRequest(string id);

        [Get("/requests")]
        Task<RequestList> GetRequests([Query()] MyParams myParams);

        [Post("/requests")]
        [Headers("Content-Type: application/json; charset=UTF-8")]
        Task CreateRequest([Body] Dictionary<string, object> obj);

        [Patch("/requests/{id}")]
        Task PatchRequest(string id, [Body] Dictionary<string, object> obj, [Header("If-Match")] string etag);

        [Delete("/requests/{id}")]
        Task DeleteRequest(string id, [Header("If-Match")] string etag);


        // NOTIFICATIONS
        [Get("/notifications/{id}")]
        Task<Notification> GetNotification(string id);

        [Get("/notifications")]
        Task<NotificationList> GetNotifications([Query()] MyParams myParams);

        [Post("/notifications")]
        [Headers("Content-Type: application/json; charset=UTF-8")]
        Task CreateNotification([Body] Dictionary<string, object> obj);

        [Patch("/notifications/{id}")]
        Task PatchNotification(string id, [Body] Dictionary<string, object> obj, [Header("If-Match")] string etag);

        [Delete("/notifications/{id}")]
        Task DeleteNotification(string id, [Header("If-Match")] string etag);
    }
}
