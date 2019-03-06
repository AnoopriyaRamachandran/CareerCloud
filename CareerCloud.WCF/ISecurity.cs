using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CareerCloud.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISecurity" in both code and config file together.
    [ServiceContract]
    public interface ISecurity
    {
        //SecurityLoginPoco

        [OperationContract]
        void AddSecurityLogin(SecurityLoginPoco[] item);
        [OperationContract]
        List<SecurityLoginPoco> GetAllSecurityLogin();
        [OperationContract]
        SecurityLoginPoco GetSingleSecurityLogin(Guid id);
        [OperationContract]
        void RemoveSecurityLogin(Guid id);
        [OperationContract]
        void UpdateSecurityLogin(SecurityLoginPoco[] items);

        //SecurityLoginsLogPoco

        [OperationContract]
        void AddSecurityLoginsLog(SecurityLoginsLogPoco[] item);
        [OperationContract]
        List<SecurityLoginsLogPoco> GetAllSecurityLoginsLog();
        [OperationContract]
        SecurityLoginsLogPoco GetSingleSecurityLoginsLog(Guid id);
        [OperationContract]
        void RemoveSecurityLoginsLog(Guid id);
        [OperationContract]
        void UpdateSecurityLoginsLog(SecurityLoginsLogPoco[] items);

        //SecurityLoginsRolePoco

        [OperationContract]
        void AddSecurityLoginsRole(SecurityLoginsRolePoco[] item);
        [OperationContract]
        List<SecurityLoginsRolePoco> GetAllSecurityLoginsRole();
        [OperationContract]
        SecurityLoginsRolePoco GetSingleSecurityLoginsRole(Guid id);
        [OperationContract]
        void RemoveSecurityLoginsRole(Guid id);
        [OperationContract]
        void UpdateSecurityLoginsRole(SecurityLoginsRolePoco[] items);

        //SecurityRolePoco

        [OperationContract]
        void AddSecurityRole(SecurityRolePoco[] item);
        [OperationContract]
        List<SecurityRolePoco> GetAllSecurityRole();
        [OperationContract]
        SecurityRolePoco GetSingleSecurityRole(Guid id);
        [OperationContract]
        void RemoveSecurityRole(Guid id);
        [OperationContract]
        void UpdateSecurityRole(SecurityRolePoco[] items);

    }
}
