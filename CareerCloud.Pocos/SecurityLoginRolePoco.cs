﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class SecurityLoginRolePoco : IPoco
    {
        public Guid Id { get; set; }
        public Guid Login { get; set; }
        public Guid Role { get; set; }
        public byte?[] TimeStamp { get; set; }

    }
}
