using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Security" in both code and config file together.
    public class Security : ISecurity
    {
        public void AddSecurityLogin(SecurityLoginPoco[] item)
        {
            throw new NotImplementedException();
        }

        public void AddSecurityLoginsLog(SecurityLoginsLogPoco[] item)
        {
            throw new NotImplementedException();
        }

        public void AddSecurityLoginsRole(SecurityLoginsRolePoco[] item)
        {
            throw new NotImplementedException();
        }

        public void AddSecurityRole(SecurityRolePoco[] item)
        {
            throw new NotImplementedException();
        }

        public List<SecurityLoginPoco> GetAllSecurityLogin()
        {
            throw new NotImplementedException();
        }

        public List<SecurityLoginsLogPoco> GetAllSecurityLoginsLog()
        {
            throw new NotImplementedException();
        }

        public List<SecurityLoginsRolePoco> GetAllSecurityLoginsRole()
        {
            throw new NotImplementedException();
        }

        public List<SecurityRolePoco> GetAllSecurityRole()
        {
            throw new NotImplementedException();
        }

        public SecurityLoginPoco GetSingleSecurityLogin(Guid id)
        {
            throw new NotImplementedException();
        }

        public SecurityLoginsLogPoco GetSingleSecurityLoginsLog(Guid id)
        {
            throw new NotImplementedException();
        }

        public SecurityLoginsRolePoco GetSingleSecurityLoginsRole(Guid id)
        {
            throw new NotImplementedException();
        }

        public SecurityRolePoco GetSingleSecurityRole(Guid id)
        {
            throw new NotImplementedException();
        }

        public void RemoveSecurityLogin(Guid id)
        {
            throw new NotImplementedException();
        }

        public void RemoveSecurityLoginsLog(Guid id)
        {
            throw new NotImplementedException();
        }

        public void RemoveSecurityLoginsRole(Guid id)
        {
            throw new NotImplementedException();
        }

        public void RemoveSecurityRole(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UpdateSecurityLogin(SecurityLoginPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void UpdateSecurityLoginsLog(SecurityLoginsLogPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void UpdateSecurityLoginsRole(SecurityLoginsRolePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void UpdateSecurityRole(SecurityRolePoco[] items)
        {
            throw new NotImplementedException();
        }
    }
}
