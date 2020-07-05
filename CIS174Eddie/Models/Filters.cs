using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174Eddie.Models
{
    public class Filters // Sorting Tickets
    {
        public Filters(string filterstring)
        {
            filterstring = filterstring ?? "all-all";
            string[] filters = filterstring.Split('-');
            PointId = filters[0];
            StatusId = filters[1];
        }
        public string FilterString { get; }
        public string PointId { get; }
        public string StatusId { get; }

        public bool HasPoint => PointId.ToLower() != "all";
        public bool HasStatus => StatusId.ToLower() != "all";

    }
}
