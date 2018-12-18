using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAppAdmin.APIClient
{
    class MyParams
    {
        [AliasAs("where")]
        public string Query { get; set; }

        [AliasAs("max_results")]
        public string Limit { get; set; }

        [AliasAs("sort")]
        public string Sort { get; set; }

        [AliasAs("embedded")]
        public string Embedded { get; set; }
    }
}
