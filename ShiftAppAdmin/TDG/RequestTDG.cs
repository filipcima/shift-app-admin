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
    class RequestTDG : IRequestTDG
    {
        public async Task AddRequestAsync(Request request)
        {
            var client = RefitClient.Service;
            //client.CreateRequest(request);
        }

        public async Task DeleteRequestAsync(Request request)
        {
            throw new NotImplementedException();
        }

        public async Task<Request> GetRequestByIdAsync(string id)
        {
            var myParams = new MyParams { Query = $"{{\"_id\":\"{id}\"}}" };
            var client = RefitClient.Service;
            var result = await client.GetRequest(id);
            Request request = new Request
            {
                Id = result.Id,
                Etag = result.Etag,
                IdCreatedBy = result.IdCreatedBy,
                IdForShift = result.IdForShift,
                Accepted = result.Accepted,
                RequestType = result.RequestType,
                Resolved = result.Resolved
            };
            return request;
        }

        public async Task<List<Request>> GetRequestsAsync(MyParams myParams)
        {
            var client = RefitClient.Service;
            var result = await client.GetRequests(myParams);
            List<Request> requests = new List<Request>();
            foreach (Request res in result.Requests)
            {
                Request req = new Request
                {
                    Id = res.Id,
                    Etag = res.Etag,
                    IdCreatedBy = res.IdCreatedBy,
                    IdForShift = res.IdForShift,
                    Accepted = res.Accepted,
                    RequestType = res.RequestType,
                    Resolved = res.Resolved
                };
                requests.Add(req);
            }
            return requests;
        }

        public async Task PatchRequestAsync(Request request)
        {
            var client = RefitClient.Service;

            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                {"accepted", request.Accepted},
                {"resolved", request.Resolved}
            };

            client.PatchRequest(request.Id, dict, request.Etag);
        }
    }
}
