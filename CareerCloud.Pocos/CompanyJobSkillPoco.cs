using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class CompanyJobSkillPoco : IPoco
    {
        public Guid Id { get; set; }
        public Guid Job { get; set; }
        public string Skill { get; set; }
        public string SkillLevel { get; set; }
        public Int32 Importance { get; set; }
        public byte[] TimeStamp { get; set; }

    }
}
