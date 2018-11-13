using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.ADODataAccessLayer
{
    public abstract class BaseADO
    {
        protected string connString;

        public BaseADO()
        {
            connString = @"Data Source = LAPTOP-BLF2U6N6\HUMBERBRIDGING; InitialCatalog = JOB_PORTAL_DB; Integrated Security = True;";
        }
    }
}
