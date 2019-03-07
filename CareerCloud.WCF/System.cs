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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ISystem" in both code and config file together.
    public class System : ISystem
    {
        public void AddSystemCountryCode(SystemCountryCodePoco[] item)
        {
            EFGenericRepository<SystemCountryCodePoco> systemcountrycoderepo = new EFGenericRepository<SystemCountryCodePoco>(false);
            SystemCountryCodeLogic _systemcountrycodelogic = new SystemCountryCodeLogic(systemcountrycoderepo);
            _systemcountrycodelogic.Add(item);
        }

        public void AddSystemLanguageCode(SystemLanguageCodePoco[] item)
        {
            EFGenericRepository<SystemLanguageCodePoco> systemlanguagecoderepo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            SystemLanguageCodeLogic _systemlanguagecodelogic = new SystemLanguageCodeLogic(systemlanguagecoderepo);
            _systemlanguagecodelogic.Add(item);
        }

        public List<SystemCountryCodePoco> GetAllSystemCountryCode()
        {
            EFGenericRepository<SystemCountryCodePoco> systemcountrycoderepo = new EFGenericRepository<SystemCountryCodePoco>(false);
            SystemCountryCodeLogic _systemcountrycodelogic = new SystemCountryCodeLogic(systemcountrycoderepo);
            return _systemcountrycodelogic.GetAll();
        }

        public List<SystemLanguageCodePoco> GetAllSystemLanguageCode()
        {
            EFGenericRepository<SystemLanguageCodePoco> systemlanguagecoderepo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            SystemLanguageCodeLogic _systemlanguagecodelogic = new SystemLanguageCodeLogic(systemlanguagecoderepo);
            return _systemlanguagecodelogic.GetAll();
        }

        public SystemCountryCodePoco GetSingleSystemCountryCode(string Code)
        {
            EFGenericRepository<SystemCountryCodePoco> systemcountrycoderepo = new EFGenericRepository<SystemCountryCodePoco>(false);
            SystemCountryCodeLogic _systemcountrycodelogic = new SystemCountryCodeLogic(systemcountrycoderepo);
            return _systemcountrycodelogic.Get(Code);
        }

        public SystemLanguageCodePoco GetSingleSystemLanguageCode(string LanguageId)
        {
            EFGenericRepository<SystemLanguageCodePoco> systemlanguagecoderepo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            SystemLanguageCodeLogic _systemlanguagecodelogic = new SystemLanguageCodeLogic(systemlanguagecoderepo);
            return _systemlanguagecodelogic.Get(LanguageId);
        }


        public void RemoveSystemCountryCode(SystemCountryCodePoco[] items)
        {
            EFGenericRepository<SystemCountryCodePoco> systemcountrycoderepo = new EFGenericRepository<SystemCountryCodePoco>(false);
            SystemCountryCodeLogic _systemcountrycodelogic = new SystemCountryCodeLogic(systemcountrycoderepo);
            _systemcountrycodelogic.Delete(items);
        }
               

        public void RemoveSystemLanguageCode(SystemLanguageCodePoco[] items)
        {
            EFGenericRepository<SystemLanguageCodePoco> systemlanguagecoderepo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            SystemLanguageCodeLogic _systemlanguagecodelogic = new SystemLanguageCodeLogic(systemlanguagecoderepo);
            _systemlanguagecodelogic.Delete(items);
        }

        public void UpdateSystemCountryCode(SystemCountryCodePoco[] items)
        {
            EFGenericRepository<SystemCountryCodePoco> systemcountrycoderepo = new EFGenericRepository<SystemCountryCodePoco>(false);
            SystemCountryCodeLogic _systemcountrycodelogic = new SystemCountryCodeLogic(systemcountrycoderepo);
            _systemcountrycodelogic.Update(items);
        }

        public void UpdateSystemLanguageCode(SystemLanguageCodePoco[] items)
        {
            EFGenericRepository<SystemLanguageCodePoco> systemlanguagecoderepo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            SystemLanguageCodeLogic _systemlanguagecodelogic = new SystemLanguageCodeLogic(systemlanguagecoderepo);
            _systemlanguagecodelogic.Update(items);
        }
    }
}
