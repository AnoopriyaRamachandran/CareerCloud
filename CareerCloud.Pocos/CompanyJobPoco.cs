using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class CompanyJobPoco : IPoco
    {
        public Guid Id { get; set; }
        public Guid Company { get; set; }
        public DateTime ProfileCreated { get; set; }
        public Boolean IsInactive { get; set; }
        public Boolean IsCompanyHidden { get; set; }
        public byte?[] TimeStamp { get; set; }

    }
    
}
