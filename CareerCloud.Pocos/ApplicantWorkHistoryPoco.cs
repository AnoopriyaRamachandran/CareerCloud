using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class ApplicantWorkHistoryPoco
    {
        public Guid Id { get; set; }
        public Guid Applicant { get; set; }
        public string CompanyName { get; set; }
        public string CountryCode { get; set; }
        public string Location { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public Int16 StartMonth { get; set; }
        public Int32 StartYear { get; set; }
        public Int16 EndMonth { get; set; }
        public Int32 EndYear { get; set; }
        public byte[] TimeStamp { get; set; }
        
    }
}
