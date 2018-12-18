using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAppAdmin.APIClient
{
    class RefitClient
    {
        private static IShiftAppService service;
        public static IShiftAppService Service
        {
            get
            {
                if (service == null)
                {
                    service = RestService.For<IShiftAppService>("http://192.168.2.103:5000");
                }
                return service;
            }
        }
        private RefitClient() { }
    }
}
