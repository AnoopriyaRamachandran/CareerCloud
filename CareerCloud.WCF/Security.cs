using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Security" in both code and config file together.
    public class Security : ISecurity
    {
        public void AddSecurityLogin(SecurityLoginPoco[] item)
        {
            EFGenericRepository<SecurityLoginPoco> securityloginrepo = new EFGenericRepository<SecurityLoginPoco>(false);
            SecurityLoginLogic _securityloginlogic = new SecurityLoginLogic(securityloginrepo);
            _securityloginlogic.Add(item);
        }

        public void AddSecurityLoginsLog(SecurityLoginsLogPoco[] item)
        {
            EFGenericRepository<SecurityLoginsLogPoco> securityloginslogrepo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            SecurityLoginsLogLogic _securityloginsloglogic = new SecurityLoginsLogLogic(securityloginslogrepo);
            _securityloginsloglogic.Add(item);
        }

        public void AddSecurityLoginsRole(SecurityLoginsRolePoco[] item)
        {
            EFGenericRepository<SecurityLoginsRolePoco> securityloginsrolerepo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            SecurityLoginsRoleLogic _securityloginsrolelogic = new SecurityLoginsRoleLogic(securityloginsrolerepo);
            _securityloginsrolelogic.Add(item);
        }

        public void AddSecurityRole(SecurityRolePoco[] item)
        {
            EFGenericRepository<SecurityRolePoco> securityrolerepo = new EFGenericRepository<SecurityRolePoco>(false);
            SecurityRoleLogic _securityrolelogic = new SecurityRoleLogic(securityrolerepo);
            _securityrolelogic.Add(item);
        }

        public List<SecurityLoginPoco> GetAllSecurityLogin()
        {
            EFGenericRepository<SecurityLoginPoco> securityloginrepo = new EFGenericRepository<SecurityLoginPoco>(false);
            SecurityLoginLogic _securityloginlogic = new SecurityLoginLogic(securityloginrepo);
            return _securityloginlogic.GetAll();
        }

        public List<SecurityLoginsLogPoco> GetAllSecurityLoginsLog()
        {
            EFGenericRepository<SecurityLoginsLogPoco> securityloginslogrepo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            SecurityLoginsLogLogic _securityloginsloglogic = new SecurityLoginsLogLogic(securityloginslogrepo);
            return _securityloginsloglogic.GetAll();
        }

        public List<SecurityLoginsRolePoco> GetAllSecurityLoginsRole()
        {
            EFGenericRepository<SecurityLoginsRolePoco> securityloginsrolerepo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            SecurityLoginsRoleLogic _securityloginsrolelogic = new SecurityLoginsRoleLogic(securityloginsrolerepo);
            return _securityloginsrolelogic.GetAll();
        }

        public List<SecurityRolePoco> GetAllSecurityRole()
        {
            EFGenericRepository<SecurityRolePoco> securityrolerepo = new EFGenericRepository<SecurityRolePoco>(false);
            SecurityRoleLogic _securityrolelogic = new SecurityRoleLogic(securityrolerepo);
            return _securityrolelogic.GetAll();
        }

        public SecurityLoginPoco GetSingleSecurityLogin(string id)
        {
            EFGenericRepository<SecurityLoginPoco> securityloginrepo = new EFGenericRepository<SecurityLoginPoco>(false);
            SecurityLoginLogic _securityloginlogic = new SecurityLoginLogic(securityloginrepo);
            return _securityloginlogic.Get(Guid.Parse(id));
        }

        public SecurityLoginsLogPoco GetSingleSecurityLoginsLog(string id)
        {
            EFGenericRepository<SecurityLoginsLogPoco> securityloginslogrepo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            SecurityLoginsLogLogic _securityloginsloglogic = new SecurityLoginsLogLogic(securityloginslogrepo);
            return _securityloginsloglogic.Get(Guid.Parse(id));
        }

        public SecurityLoginsRolePoco GetSingleSecurityLoginsRole(string id)
        {
            EFGenericRepository<SecurityLoginsRolePoco> securityloginsrolerepo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            SecurityLoginsRoleLogic _securityloginsrolelogic = new SecurityLoginsRoleLogic(securityloginsrolerepo);
            return _securityloginsrolelogic.Get(Guid.Parse(id));
        }

        public SecurityRolePoco GetSingleSecurityRole(string id)
        {
            EFGenericRepository<SecurityRolePoco> securityrolerepo = new EFGenericRepository<SecurityRolePoco>(false);
            SecurityRoleLogic _securityrolelogic = new SecurityRoleLogic(securityrolerepo);
            return _securityrolelogic.Get(Guid.Parse(id));
        }

        public void RemoveSecurityLogin(SecurityLoginPoco[] items)
        {
            EFGenericRepository<SecurityLoginPoco> securityloginrepo = new EFGenericRepository<SecurityLoginPoco>(false);
            SecurityLoginLogic _securityloginlogic = new SecurityLoginLogic(securityloginrepo);
            _securityloginlogic.Delete(items);
        }

        public void RemoveSecurityLoginsLog(SecurityLoginsLogPoco[] items)
        {
            EFGenericRepository<SecurityLoginsLogPoco> securityloginslogrepo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            SecurityLoginsLogLogic _securityloginsloglogic = new SecurityLoginsLogLogic(securityloginslogrepo);
            _securityloginsloglogic.Delete(items);
        }

        public void RemoveSecurityLoginsRole(SecurityLoginsRolePoco[] items)
        {
            EFGenericRepository<SecurityLoginsRolePoco> securityloginsrolerepo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            SecurityLoginsRoleLogic _securityloginsrolelogic = new SecurityLoginsRoleLogic(securityloginsrolerepo);
            _securityloginsrolelogic.Delete(items);
        }

        public void RemoveSecurityRole(SecurityRolePoco[] items)
        {
            EFGenericRepository<SecurityRolePoco> securityrolerepo = new EFGenericRepository<SecurityRolePoco>(false);
            SecurityRoleLogic _securityrolelogic = new SecurityRoleLogic(securityrolerepo);
            _securityrolelogic.Delete(items);
        }

        public void UpdateSecurityLogin(SecurityLoginPoco[] items)
        {
            EFGenericRepository<SecurityLoginPoco> securityloginrepo = new EFGenericRepository<SecurityLoginPoco>(false);
            SecurityLoginLogic _securityloginlogic = new SecurityLoginLogic(securityloginrepo);
            _securityloginlogic.Update(items);
        }

        public void UpdateSecurityLoginsLog(SecurityLoginsLogPoco[] items)
        {
            EFGenericRepository<SecurityLoginsLogPoco> securityloginslogrepo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            SecurityLoginsLogLogic _securityloginsloglogic = new SecurityLoginsLogLogic(securityloginslogrepo);
            _securityloginsloglogic.Update(items);
        }

        public void UpdateSecurityLoginsRole(SecurityLoginsRolePoco[] items)
        {
            EFGenericRepository<SecurityLoginsRolePoco> securityloginsrolerepo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            SecurityLoginsRoleLogic _securityloginsrolelogic = new SecurityLoginsRoleLogic(securityloginsrolerepo);
            _securityloginsrolelogic.Update(items);
        }

        public void UpdateSecurityRole(SecurityRolePoco[] items)
        {
            EFGenericRepository<SecurityRolePoco> securityrolerepo = new EFGenericRepository<SecurityRolePoco>(false);
            SecurityRoleLogic _securityrolelogic = new SecurityRoleLogic(securityrolerepo);
            _securityrolelogic.Update(items);
        }
    }
}
