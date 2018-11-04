using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class SecurityLoginLogPoco : IPoco
    {
        public Guid Id { get; set; }
        public Guid Login { get; set; }
        public string SourceIP { get; set; }
        public DateTime LogonDate { get; set; }
        public Boolean IsSuccesful { get; set; }

    }
}
