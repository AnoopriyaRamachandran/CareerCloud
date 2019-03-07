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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Applicant : IApplicant
    {    
        
        public void AddApplicantEducation(ApplicantEducationPoco[] item)
        {
            EFGenericRepository<ApplicantEducationPoco> applicanteducationrepo = new EFGenericRepository<ApplicantEducationPoco>(false);
            ApplicantEducationLogic _applicanteducationlogic = new ApplicantEducationLogic(applicanteducationrepo);
            _applicanteducationlogic.Add(item);

        }

        public void AddApplicantJobApplication(ApplicantJobApplicationPoco[] item)
        {
            EFGenericRepository<ApplicantJobApplicationPoco> applicantjobapplicationrepo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            ApplicantJobApplicationLogic _applicantjobapplicationlogic = new ApplicantJobApplicationLogic(applicantjobapplicationrepo);
            _applicantjobapplicationlogic.Add(item);
        }

        public void AddApplicantProfile(ApplicantProfilePoco[] item)
        {
            EFGenericRepository<ApplicantProfilePoco> applicantprofilerepo = new EFGenericRepository<ApplicantProfilePoco>(false);
            ApplicantProfileLogic _applicantprofilelogic = new ApplicantProfileLogic(applicantprofilerepo);
            _applicantprofilelogic.Add(item);
        }

        public void AddApplicantResume(ApplicantResumePoco[] item)
        {
            EFGenericRepository<ApplicantResumePoco> applicantresumerepo = new EFGenericRepository<ApplicantResumePoco>(false);
            ApplicantResumeLogic _applicantresumelogic = new ApplicantResumeLogic(applicantresumerepo);
            _applicantresumelogic.Add(item);
        }

        public void AddApplicantSkill(ApplicantSkillPoco[] item)
        {
            EFGenericRepository<ApplicantSkillPoco> applicantskillrepo = new EFGenericRepository<ApplicantSkillPoco>(false);
            ApplicantSkillLogic _applicantskilllogic = new ApplicantSkillLogic(applicantskillrepo);
            _applicantskilllogic.Add(item);
        }

        public void AddApplicantWorkHistory(ApplicantWorkHistoryPoco[] item)
        {
            EFGenericRepository<ApplicantWorkHistoryPoco> applicantworkhistoryrepo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            ApplicantWorkHistoryLogic _applicantworkhistorylogic = new ApplicantWorkHistoryLogic(applicantworkhistoryrepo);
            _applicantworkhistorylogic.Add(item);
        }

        public List<ApplicantEducationPoco> GetAllApplicantEducation()
        {
            EFGenericRepository<ApplicantEducationPoco> applicanteducationrepo = new EFGenericRepository<ApplicantEducationPoco>(false);
            ApplicantEducationLogic _applicanteducationlogic = new ApplicantEducationLogic(applicanteducationrepo);
            return _applicanteducationlogic.GetAll();
        }

        public List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication()
        {
            EFGenericRepository<ApplicantJobApplicationPoco> applicantjobapplicationrepo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            ApplicantJobApplicationLogic _applicantjobapplicationlogic = new ApplicantJobApplicationLogic(applicantjobapplicationrepo);
            return _applicantjobapplicationlogic.GetAll();
        }

        public List<ApplicantProfilePoco> GetAllApplicantProfile()
        {
            EFGenericRepository<ApplicantProfilePoco> applicantprofilerepo = new EFGenericRepository<ApplicantProfilePoco>(false);
            ApplicantProfileLogic _applicantprofilelogic = new ApplicantProfileLogic(applicantprofilerepo);
            return _applicantprofilelogic.GetAll();
        }

        public List<ApplicantResumePoco> GetAllApplicantResume()
        {
            EFGenericRepository<ApplicantResumePoco> applicantresumerepo = new EFGenericRepository<ApplicantResumePoco>(false);
            ApplicantResumeLogic _applicantresumelogic = new ApplicantResumeLogic(applicantresumerepo);
            return _applicantresumelogic.GetAll();
        }

        public List<ApplicantSkillPoco> GetAllApplicantSkill()
        {
            EFGenericRepository<ApplicantSkillPoco> applicantskillrepo = new EFGenericRepository<ApplicantSkillPoco>(false);
            ApplicantSkillLogic _applicantskilllogic = new ApplicantSkillLogic(applicantskillrepo);
            return _applicantskilllogic.GetAll();
        }

        public List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory()
        {
            EFGenericRepository<ApplicantWorkHistoryPoco> applicantworkhistoryrepo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            ApplicantWorkHistoryLogic _applicantworkhistorylogic = new ApplicantWorkHistoryLogic(applicantworkhistoryrepo);
            return _applicantworkhistorylogic.GetAll();
        }

        public ApplicantEducationPoco GetSingleApplicantEducation(Guid id)
        {
            EFGenericRepository<ApplicantEducationPoco> applicanteducationrepo = new EFGenericRepository<ApplicantEducationPoco>(false);
            ApplicantEducationLogic _applicanteducationlogic = new ApplicantEducationLogic(applicanteducationrepo);
            return _applicanteducationlogic.Get(id);
        }

        public ApplicantJobApplicationPoco GetSingleApplicantJobApplication(Guid id)
        {
            EFGenericRepository<ApplicantJobApplicationPoco> applicantjobapplicationrepo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            ApplicantJobApplicationLogic _applicantjobapplicationlogic = new ApplicantJobApplicationLogic(applicantjobapplicationrepo);
            return _applicantjobapplicationlogic.Get(id);
        }

        public ApplicantProfilePoco GetSingleApplicantProfile(Guid id)
        {
            EFGenericRepository<ApplicantProfilePoco> applicantprofilerepo = new EFGenericRepository<ApplicantProfilePoco>(false);
            ApplicantProfileLogic _applicantprofilelogic = new ApplicantProfileLogic(applicantprofilerepo);
            return _applicantprofilelogic.Get(id);
        }

        public ApplicantResumePoco GetSingleApplicantResume(Guid id)
        {
            EFGenericRepository<ApplicantResumePoco> applicantresumerepo = new EFGenericRepository<ApplicantResumePoco>(false);
            ApplicantResumeLogic _applicantresumelogic = new ApplicantResumeLogic(applicantresumerepo);
            return _applicantresumelogic.Get(id);
        }

        public ApplicantSkillPoco GetSingleApplicantSkill(Guid id)
        {
            EFGenericRepository<ApplicantSkillPoco> applicantskillrepo = new EFGenericRepository<ApplicantSkillPoco>(false);
            ApplicantSkillLogic _applicantskilllogic = new ApplicantSkillLogic(applicantskillrepo);
            return _applicantskilllogic.Get(id);
        }

        public ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(Guid id)
        {
            EFGenericRepository<ApplicantWorkHistoryPoco> applicantworkhistoryrepo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            ApplicantWorkHistoryLogic _applicantworkhistorylogic = new ApplicantWorkHistoryLogic(applicantworkhistoryrepo);
            return _applicantworkhistorylogic.Get(id);
        }

       

        public void RemoveApplicantEducation(ApplicantEducationPoco[] items)
        {
            EFGenericRepository<ApplicantEducationPoco> applicanteducationrepo = new EFGenericRepository<ApplicantEducationPoco>(false);
            ApplicantEducationLogic _applicanteducationlogic = new ApplicantEducationLogic(applicanteducationrepo);
            _applicanteducationlogic.Delete(items);
        }

       

        public void RemoveApplicantJobApplication(ApplicantJobApplicationPoco[] items)
        {
            EFGenericRepository<ApplicantJobApplicationPoco> applicantjobapplicationrepo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            ApplicantJobApplicationLogic _applicantjobapplicationlogic = new ApplicantJobApplicationLogic(applicantjobapplicationrepo);
            _applicantjobapplicationlogic.Delete(items);
        }

    

        public void RemoveApplicantProfile(ApplicantProfilePoco[] items)
        {
            EFGenericRepository<ApplicantProfilePoco> applicantprofilerepo = new EFGenericRepository<ApplicantProfilePoco>(false);
            ApplicantProfileLogic _applicantprofilelogic = new ApplicantProfileLogic(applicantprofilerepo);
            _applicantprofilelogic.Delete(items);
        }

        

        public void RemoveApplicantResume(ApplicantResumePoco[] items)
        {
            EFGenericRepository<ApplicantResumePoco> applicantresumerepo = new EFGenericRepository<ApplicantResumePoco>(false);
            ApplicantResumeLogic _applicantresumelogic = new ApplicantResumeLogic(applicantresumerepo);
            _applicantresumelogic.Delete(items);
        }

       

        public void RemoveApplicantSkill(ApplicantSkillPoco[] items)
        {
            EFGenericRepository<ApplicantSkillPoco> applicantskillrepo = new EFGenericRepository<ApplicantSkillPoco>(false);
            ApplicantSkillLogic _applicantskilllogic = new ApplicantSkillLogic(applicantskillrepo);
            _applicantskilllogic.Delete(items);
        }
     

        public void RemoveApplicantWorkHistory(ApplicantWorkHistoryPoco[] items)
        {
            EFGenericRepository<ApplicantWorkHistoryPoco> applicantworkhistoryrepo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            ApplicantWorkHistoryLogic _applicantworkhistorylogic = new ApplicantWorkHistoryLogic(applicantworkhistoryrepo);
            _applicantworkhistorylogic.Delete(items);
        }

        public void UpdateApplicantEducation(ApplicantEducationPoco[] items)
        {
            EFGenericRepository<ApplicantEducationPoco> applicanteducationrepo = new EFGenericRepository<ApplicantEducationPoco>(false);
            ApplicantEducationLogic _applicanteducationlogic = new ApplicantEducationLogic(applicanteducationrepo);
            _applicanteducationlogic.Update(items);
        }

        public void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] items)
        {
            EFGenericRepository<ApplicantJobApplicationPoco> applicantjobapplicationrepo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            ApplicantJobApplicationLogic _applicantjobapplicationlogic = new ApplicantJobApplicationLogic(applicantjobapplicationrepo);
            _applicantjobapplicationlogic.Update(items);
        }

        public void UpdateApplicantProfile(ApplicantProfilePoco[] items)
        {
            EFGenericRepository<ApplicantProfilePoco> applicantprofilerepo = new EFGenericRepository<ApplicantProfilePoco>(false);
            ApplicantProfileLogic _applicantprofilelogic = new ApplicantProfileLogic(applicantprofilerepo);
            _applicantprofilelogic.Update(items);
        }

        public void UpdateApplicantResume(ApplicantResumePoco[] items)
        {
            EFGenericRepository<ApplicantResumePoco> applicantresumerepo = new EFGenericRepository<ApplicantResumePoco>(false);
            ApplicantResumeLogic _applicantresumelogic = new ApplicantResumeLogic(applicantresumerepo);
            _applicantresumelogic.Update(items);
        }

        public void UpdateApplicantSkill(ApplicantSkillPoco[] items)
        {
            EFGenericRepository<ApplicantSkillPoco> applicantskillrepo = new EFGenericRepository<ApplicantSkillPoco>(false);
            ApplicantSkillLogic _applicantskilllogic = new ApplicantSkillLogic(applicantskillrepo);
            _applicantskilllogic.Update(items);
        }

        public void UpdateApplicantWorkHistory(ApplicantWorkHistoryPoco[] items)
        {
            EFGenericRepository<ApplicantWorkHistoryPoco> applicantworkhistoryrepo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            ApplicantWorkHistoryLogic _applicantworkhistorylogic = new ApplicantWorkHistoryLogic(applicantworkhistoryrepo);
            _applicantworkhistorylogic.Update(items);
        }
    }
}
