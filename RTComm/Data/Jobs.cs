using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTComm.Data
{
    public class Jobs
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public string JobCategory { get; set; }
        public decimal Cost { get; set; }
        public string ConstructionCompany { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ClientName { get; set; }
        public ICollection <Comments> Comments { get; set; }

    }
}
