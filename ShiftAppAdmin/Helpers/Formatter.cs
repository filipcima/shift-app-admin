using ShiftAppAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAppAdmin.Helpers
{
    class Formatter
    {

        public static string GetShiftInfoString(string dateFromString, string dateToString)
        {
            StringBuilder sb = new StringBuilder();
            DateTime from = DateTime.Parse(dateFromString);
            DateTime to = DateTime.Parse(dateToString);

            sb.Append(from.Day);
            sb.Append("/");
            sb.Append(from.Month);
            sb.Append("/");
            sb.Append(from.Year);
            sb.Append(" ");
            sb.Append(from.Hour);
            sb.Append(":");
            sb.Append(from.Minute);
            sb.Append(" - ");
            sb.Append(to.Hour);
            sb.Append(":");
            sb.Append(to.Minute);

            return sb.ToString();
        }

        public static string GetWorkersString(List<User> workers)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < workers.Count; i++)
            {
                sb.Append(workers[i].Firstname);
                sb.Append(" ");
                sb.Append(workers[i].Secondname);

                if (i != workers.Count - 1)
                {
                    sb.Append(", ");
                }
            }

            return sb.ToString();
        }
    }
}
