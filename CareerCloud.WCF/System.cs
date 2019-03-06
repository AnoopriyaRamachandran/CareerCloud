using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ISystem" in both code and config file together.
    public class System : ISystem
    {
        public void AddSystemCountryCode(SystemCountryCodePoco[] item)
        {
            throw new NotImplementedException();
        }

        public void AddSystemLanguageCode(SystemLanguageCodePoco[] item)
        {
            throw new NotImplementedException();
        }

        public List<SystemCountryCodePoco> GetAllSystemCountryCode()
        {
            throw new NotImplementedException();
        }

        public List<SystemLanguageCodePoco> GetAllSystemLanguageCode()
        {
            throw new NotImplementedException();
        }

        public SystemCountryCodePoco GetSingleSystemCountryCode(Guid Code)
        {
            throw new NotImplementedException();
        }

        public SystemLanguageCodePoco GetSingleSystemLanguageCode(Guid LanguageId)
        {
            throw new NotImplementedException();
        }

        public void RemoveSystemCountryCode(Guid Code)
        {
            throw new NotImplementedException();
        }

        public void RemoveSystemLanguageCode(Guid LanguageId)
        {
            throw new NotImplementedException();
        }

        public void UpdateSystemCountryCode(SystemCountryCodePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void UpdateSystemLanguageCode(SystemLanguageCodePoco[] items)
        {
            throw new NotImplementedException();
        }
    }
}
