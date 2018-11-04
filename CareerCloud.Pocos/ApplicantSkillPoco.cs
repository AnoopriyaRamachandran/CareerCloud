﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class ApplicantSkillPoco : IPoco
    {
        public Guid Id { get; set; }
        public Guid Applicant { get; set; }
        public string Skill { get; set; }
        public string SkillLevel { get; set; }
        public byte StartMonth { get; set; }
        public Int32 StartYear { get; set; }
        public byte EndMonth { get; set; }
        public Int32 EndYear { get; set; }
        public byte[] TimeStamp { get; set; }

    }

}
