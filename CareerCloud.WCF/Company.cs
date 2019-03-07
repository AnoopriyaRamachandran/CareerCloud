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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Company" in both code and config file together.
    public class Company : ICompany
    {
        public void AddCompanyDescription(CompanyDescriptionPoco[] item)
        {
            EFGenericRepository<CompanyDescriptionPoco> companydescriptionrepo = new EFGenericRepository<CompanyDescriptionPoco>(false);
            CompanyDescriptionLogic _companydescriptionlogic = new CompanyDescriptionLogic(companydescriptionrepo);
            _companydescriptionlogic.Add(item);
        }

        public void AddCompanyJob(CompanyJobPoco[] item)
        {
            EFGenericRepository<CompanyJobPoco> companyjobrepo = new EFGenericRepository<CompanyJobPoco>(false);
            CompanyJobLogic _companyjoblogic = new CompanyJobLogic(companyjobrepo);
            _companyjoblogic.Add(item);
        }

        public void AddCompanyJobDescription(CompanyJobDescriptionPoco[] item)
        {
            EFGenericRepository<CompanyJobDescriptionPoco> companyjobdescriptionrepo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
            CompanyJobDescriptionLogic _companyjobdescriptionlogic = new CompanyJobDescriptionLogic(companyjobdescriptionrepo);
            _companyjobdescriptionlogic.Add(item);
        }

        public void AddCompanyJobEducation(CompanyJobEducationPoco[] item)
        {
            EFGenericRepository<CompanyJobEducationPoco> companyjobeducationrepo = new EFGenericRepository<CompanyJobEducationPoco>(false);
            CompanyJobEducationLogic _companyjobeducationlogic = new CompanyJobEducationLogic(companyjobeducationrepo);
            _companyjobeducationlogic.Add(item);
        }

        public void AddCompanyJobSkill(CompanyJobSkillPoco[] item)
        {
            EFGenericRepository<CompanyJobSkillPoco> companyjobskillrepo = new EFGenericRepository<CompanyJobSkillPoco>(false);
            CompanyJobSkillLogic _companyjobskilllogic = new CompanyJobSkillLogic(companyjobskillrepo);
            _companyjobskilllogic.Add(item);
        }

        public void AddCompanyLocation(CompanyLocationPoco[] item)
        {
            EFGenericRepository<CompanyLocationPoco> companylocationrepo = new EFGenericRepository<CompanyLocationPoco>(false);
            CompanyLocationLogic _companylocationlogic = new CompanyLocationLogic(companylocationrepo);
            _companylocationlogic.Add(item);
        }

        public void AddCompanyProfile(CompanyProfilePoco[] item)
        {
            EFGenericRepository<CompanyProfilePoco> companyprofilerepo = new EFGenericRepository<CompanyProfilePoco>(false);
            CompanyProfileLogic _companyprofilelogic = new CompanyProfileLogic(companyprofilerepo);
            _companyprofilelogic.Add(item);
        }
              

        public List<CompanyDescriptionPoco> GetAllCompanyDescription()
        {
            EFGenericRepository<CompanyDescriptionPoco> companydescriptionrepo = new EFGenericRepository<CompanyDescriptionPoco>(false);
            CompanyDescriptionLogic _companydescriptionlogic = new CompanyDescriptionLogic(companydescriptionrepo);
            return _companydescriptionlogic.GetAll();
        }

        public List<CompanyJobPoco> GetAllCompanyJob()
        {
            EFGenericRepository<CompanyJobPoco> companyjobrepo = new EFGenericRepository<CompanyJobPoco>(false);
            CompanyJobLogic _companyjoblogic = new CompanyJobLogic(companyjobrepo);
            return _companyjoblogic.GetAll();
        }

        public List<CompanyJobDescriptionPoco> GetAllCompanyJobDescription()
        {
            EFGenericRepository<CompanyJobDescriptionPoco> companyjobdescriptionrepo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
            CompanyJobDescriptionLogic _companyjobdescriptionlogic = new CompanyJobDescriptionLogic(companyjobdescriptionrepo);
            return _companyjobdescriptionlogic.GetAll();
        }

        public List<CompanyJobEducationPoco> GetAllCompanyJobEducation()
        {
            EFGenericRepository<CompanyJobEducationPoco> companyjobeducationrepo = new EFGenericRepository<CompanyJobEducationPoco>(false);
            CompanyJobEducationLogic _companyjobeducationlogic = new CompanyJobEducationLogic(companyjobeducationrepo);
            return _companyjobeducationlogic.GetAll();
        }

        public List<CompanyJobSkillPoco> GetAllCompanyJobSkill()
        {
            EFGenericRepository<CompanyJobSkillPoco> companyjobskillrepo = new EFGenericRepository<CompanyJobSkillPoco>(false);
            CompanyJobSkillLogic _companyjobskilllogic = new CompanyJobSkillLogic(companyjobskillrepo);
            return _companyjobskilllogic.GetAll();
        }

        public List<CompanyLocationPoco> GetAllCompanyLocation()
        {
            EFGenericRepository<CompanyLocationPoco> companylocationrepo = new EFGenericRepository<CompanyLocationPoco>(false);
            CompanyLocationLogic _companylocationlogic = new CompanyLocationLogic(companylocationrepo);
            return _companylocationlogic.GetAll();
        }

        public List<CompanyProfilePoco> GetAllCompanyProfile()
        {
            EFGenericRepository<CompanyProfilePoco> companyprofilerepo = new EFGenericRepository<CompanyProfilePoco>(false);
            CompanyProfileLogic _companyprofilelogic = new CompanyProfileLogic(companyprofilerepo);
            return _companyprofilelogic.GetAll();
        }

        public CompanyDescriptionPoco GetSingleCompanyDescription(Guid id)
        {
            EFGenericRepository<CompanyDescriptionPoco> companydescriptionrepo = new EFGenericRepository<CompanyDescriptionPoco>(false);
            CompanyDescriptionLogic _companydescriptionlogic = new CompanyDescriptionLogic(companydescriptionrepo);
            return _companydescriptionlogic.Get(id);
        }

        public CompanyJobPoco GetSingleCompanyJob(Guid id)
        {
            EFGenericRepository<CompanyJobPoco> companyjobrepo = new EFGenericRepository<CompanyJobPoco>(false);
            CompanyJobLogic _companyjoblogic = new CompanyJobLogic(companyjobrepo);
            return _companyjoblogic.Get(id);
        }

        public CompanyJobDescriptionPoco GetSingleCompanyJobDescription(Guid id)
        {
            EFGenericRepository<CompanyJobDescriptionPoco> companyjobdescriptionrepo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
            CompanyJobDescriptionLogic _companyjobdescriptionlogic = new CompanyJobDescriptionLogic(companyjobdescriptionrepo);
            return _companyjobdescriptionlogic.Get(id);
        }

        public CompanyJobEducationPoco GetSingleCompanyJobEducation(Guid id)
        {
            EFGenericRepository<CompanyJobEducationPoco> companyjobeducationrepo = new EFGenericRepository<CompanyJobEducationPoco>(false);
            CompanyJobEducationLogic _companyjobeducationlogic = new CompanyJobEducationLogic(companyjobeducationrepo);
            return _companyjobeducationlogic.Get(id);
        }

        public CompanyJobSkillPoco GetSingleCompanyJobSkill(Guid id)
        {
            EFGenericRepository<CompanyJobSkillPoco> companyjobskillrepo = new EFGenericRepository<CompanyJobSkillPoco>(false);
            CompanyJobSkillLogic _companyjobskilllogic = new CompanyJobSkillLogic(companyjobskillrepo);
            return _companyjobskilllogic.Get(id);
        }

        public CompanyLocationPoco GetSingleCompanyLocation(Guid id)
        {
            EFGenericRepository<CompanyLocationPoco> companylocationrepo = new EFGenericRepository<CompanyLocationPoco>(false);
            CompanyLocationLogic _companylocationlogic = new CompanyLocationLogic(companylocationrepo);
            return _companylocationlogic.Get(id);
        }

        public CompanyProfilePoco GetSingleCompanyProfile(Guid id)
        {
            EFGenericRepository<CompanyProfilePoco> companyprofilerepo = new EFGenericRepository<CompanyProfilePoco>(false);
            CompanyProfileLogic _companyprofilelogic = new CompanyProfileLogic(companyprofilerepo);
            return _companyprofilelogic.Get(id);
        }

        public void RemoveCompanyDescription(CompanyDescriptionPoco[] items)
        {
            EFGenericRepository<CompanyDescriptionPoco> companydescriptionrepo = new EFGenericRepository<CompanyDescriptionPoco>(false);
            CompanyDescriptionLogic _companydescriptionlogic = new CompanyDescriptionLogic(companydescriptionrepo);
            _companydescriptionlogic.Delete(items);
        }

        public void RemoveCompanyJob(CompanyJobPoco[] items)
        {
            EFGenericRepository<CompanyJobPoco> companyjobrepo = new EFGenericRepository<CompanyJobPoco>(false);
            CompanyJobLogic _companyjoblogic = new CompanyJobLogic(companyjobrepo);
            _companyjoblogic.Delete(items);
        }

        public void RemoveCompanyJobDescription(CompanyJobDescriptionPoco[] items)
        {
            EFGenericRepository<CompanyJobDescriptionPoco> companyjobdescriptionrepo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
            CompanyJobDescriptionLogic _companyjobdescriptionlogic = new CompanyJobDescriptionLogic(companyjobdescriptionrepo);
            _companyjobdescriptionlogic.Delete(items);
        }

        public void RemoveCompanyJobEducation(CompanyJobEducationPoco[] items)
        {
            EFGenericRepository<CompanyJobEducationPoco> companyjobeducationrepo = new EFGenericRepository<CompanyJobEducationPoco>(false);
            CompanyJobEducationLogic _companyjobeducationlogic = new CompanyJobEducationLogic(companyjobeducationrepo);
            _companyjobeducationlogic.Delete(items);
        }

        public void RemoveCompanyJobSkill(CompanyJobSkillPoco[] items)
        {
            EFGenericRepository<CompanyJobSkillPoco> companyjobskillrepo = new EFGenericRepository<CompanyJobSkillPoco>(false);
            CompanyJobSkillLogic _companyjobskilllogic = new CompanyJobSkillLogic(companyjobskillrepo);
            _companyjobskilllogic.Delete(items);
        }

        public void RemoveCompanyLocation(CompanyLocationPoco[] items)
        {
            EFGenericRepository<CompanyLocationPoco> companylocationrepo = new EFGenericRepository<CompanyLocationPoco>(false);
            CompanyLocationLogic _companylocationlogic = new CompanyLocationLogic(companylocationrepo);
            _companylocationlogic.Delete(items);
        }

        public void RemoveCompanyProfile(CompanyProfilePoco[] items)
        {
            EFGenericRepository<CompanyProfilePoco> companyprofilerepo = new EFGenericRepository<CompanyProfilePoco>(false);
            CompanyProfileLogic _companyprofilelogic = new CompanyProfileLogic(companyprofilerepo);
            _companyprofilelogic.Delete(items);
        }

        public void UpdateCompanyDescription(CompanyDescriptionPoco[] items)
        {
            EFGenericRepository<CompanyDescriptionPoco> companydescriptionrepo = new EFGenericRepository<CompanyDescriptionPoco>(false);
            CompanyDescriptionLogic _companydescriptionlogic = new CompanyDescriptionLogic(companydescriptionrepo);
            _companydescriptionlogic.Update(items);
        }

        public void UpdateCompanyJob(CompanyJobPoco[] items)
        {
            EFGenericRepository<CompanyJobPoco> companyjobrepo = new EFGenericRepository<CompanyJobPoco>(false);
            CompanyJobLogic _companyjoblogic = new CompanyJobLogic(companyjobrepo);
            _companyjoblogic.Update(items);
        }

        public void UpdateCompanyJobDescription(CompanyJobDescriptionPoco[] items)
        {
            EFGenericRepository<CompanyJobDescriptionPoco> companyjobdescriptionrepo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
            CompanyJobDescriptionLogic _companyjobdescriptionlogic = new CompanyJobDescriptionLogic(companyjobdescriptionrepo);
            _companyjobdescriptionlogic.Update(items);
        }

        public void UpdateCompanyJobEducation(CompanyJobEducationPoco[] items)
        {
            EFGenericRepository<CompanyJobEducationPoco> companyjobeducationrepo = new EFGenericRepository<CompanyJobEducationPoco>(false);
            CompanyJobEducationLogic _companyjobeducationlogic = new CompanyJobEducationLogic(companyjobeducationrepo);
            _companyjobeducationlogic.Update(items);
        }

        public void UpdateCompanyJobSkill(CompanyJobSkillPoco[] items)
        {
            EFGenericRepository<CompanyJobSkillPoco> companyjobskillrepo = new EFGenericRepository<CompanyJobSkillPoco>(false);
            CompanyJobSkillLogic _companyjobskilllogic = new CompanyJobSkillLogic(companyjobskillrepo);
            _companyjobskilllogic.Update(items);
        }

        public void UpdateCompanyLocation(CompanyLocationPoco[] items)
        {
            EFGenericRepository<CompanyLocationPoco> companylocationrepo = new EFGenericRepository<CompanyLocationPoco>(false);
            CompanyLocationLogic _companylocationlogic = new CompanyLocationLogic(companylocationrepo);
            _companylocationlogic.Update(items);
        }

        public void UpdateCompanyProfile(CompanyProfilePoco[] items)
        {
            EFGenericRepository<CompanyProfilePoco> companyprofilerepo = new EFGenericRepository<CompanyProfilePoco>(false);
            CompanyProfileLogic _companyprofilelogic = new CompanyProfileLogic(companyprofilerepo);
            _companyprofilelogic.Update(items);
        }
    }
}
