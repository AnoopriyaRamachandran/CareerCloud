using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class CompanyJobEducationPoco : IPoco
    {
        public Guid Id { get; set; }
        public Guid Job { get; set; }
        public string Major { get; set; }
        public Int16 Importance { get; set; }
        public byte[] TimeStamp { get; set; }

    }
    
}
