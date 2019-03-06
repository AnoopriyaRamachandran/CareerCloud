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
        private ApplicantEducationLogic _applicanteducationlogic;
        private ApplicantJobApplicationLogic _applicantjobapplicationlogic;
        private ApplicantProfileLogic _applicantprofilelogic;
        private ApplicantResumeLogic _applicantresumelogic;
        private ApplicantSkillLogic _applicantskilllogic;
        private ApplicantWorkHistoryLogic _applicantworkhistorylogic;

        public Applicant()
        {
            EFGenericRepository<ApplicantEducationPoco> applicanteducationrepo = new EFGenericRepository<ApplicantEducationPoco>(false);
            EFGenericRepository<ApplicantJobApplicationPoco> applicantjobapplicationrepo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            EFGenericRepository<ApplicantProfilePoco> applicantprofilerepo = new EFGenericRepository<ApplicantProfilePoco>(false);
            EFGenericRepository<ApplicantResumePoco> applicantresumerepo = new EFGenericRepository<ApplicantResumePoco>(false);
            EFGenericRepository<ApplicantSkillPoco> applicantskillrepo = new EFGenericRepository<ApplicantSkillPoco>(false);
            EFGenericRepository<ApplicantWorkHistoryPoco> applicantworkhistoryrepo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);

            _applicanteducationlogic = new ApplicantEducationLogic(applicanteducationrepo);
            _applicantjobapplicationlogic = new ApplicantJobApplicationLogic(applicantjobapplicationrepo);
            _applicantprofilelogic = new ApplicantProfileLogic(applicantprofilerepo);
            _applicantresumelogic = new ApplicantResumeLogic(applicantresumerepo);
            _applicantskilllogic = new ApplicantSkillLogic(applicantskillrepo);
            _applicantworkhistorylogic = new ApplicantWorkHistoryLogic(applicantworkhistoryrepo);
        }
        public void AddApplicantEducation(ApplicantEducationPoco[] item)
        {
            _applicanteducationlogic.Add(item);

        }

        public void AddApplicantJobApplication(ApplicantJobApplicationPoco[] item)
        {
            _applicantjobapplicationlogic.Add(item);
        }

        public void AddApplicantProfile(ApplicantProfilePoco[] item)
        {
            _applicantprofilelogic.Add(item);
        }

        public void AddApplicantResume(ApplicantResumePoco[] item)
        {
            _applicantresumelogic.Add(item);
        }

        public void AddApplicantSkill(ApplicantSkillPoco[] item)
        {
            _applicantskilllogic.Add(item);
        }

        public void AddApplicantWorkHistory(ApplicantWorkHistoryPoco[] item)
        {
            _applicantworkhistorylogic.Add(item);
        }

        public List<ApplicantEducationPoco> GetAllApplicantEducation()
        {
            return _applicanteducationlogic.GetAll();
        }

        public List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication()
        {
            return _applicantjobapplicationlogic.GetAll();
        }

        public List<ApplicantProfilePoco> GetAllApplicantProfile()
        {
            return _applicantprofilelogic.GetAll();
        }

        public List<ApplicantResumePoco> GetAllApplicantResume()
        {
            return _applicantresumelogic.GetAll();
        }

        public List<ApplicantSkillPoco> GetAllApplicantSkill()
        {
            return _applicantskilllogic.GetAll();
        }

        public List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory()
        {
            return _applicantworkhistorylogic.GetAll();
        }

        public ApplicantEducationPoco GetSingleApplicantEducation(Guid id)
        {
            return _applicanteducationlogic.Get(id);
        }

        public ApplicantJobApplicationPoco GetSingleApplicantJobApplication(Guid id)
        {
            return _applicantjobapplicationlogic.Get(id);
        }

        public ApplicantProfilePoco GetSingleApplicantProfile(Guid id)
        {
            return _applicantprofilelogic.Get(id);
        }

        public ApplicantResumePoco GetSingleApplicantResume(Guid id)
        {
            return _applicantresumelogic.Get(id);
        }

        public ApplicantSkillPoco GetSingleApplicantSkill(Guid id)
        {
            return _applicantskilllogic.Get(id);
        }

        public ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(Guid id)
        {
            return _applicantworkhistorylogic.Get(id);
        }

       

        public void RemoveApplicantEducation(ApplicantEducationPoco[] items)
        {
            _applicanteducationlogic.Delete(items);
        }

       

        public void RemoveApplicantJobApplication(ApplicantJobApplicationPoco[] items)
        {
            _applicantjobapplicationlogic.Delete(items);
        }

    

        public void RemoveApplicantProfile(ApplicantProfilePoco[] items)
        {
            _applicantprofilelogic.Delete(items);
        }

        

        public void RemoveApplicantResume(ApplicantResumePoco[] items)
        {
            _applicantresumelogic.Delete(items);
        }

       

        public void RemoveApplicantSkill(ApplicantSkillPoco[] items)
        {
            _applicantskilllogic.Delete(items);
        }
     

        public void RemoveApplicantWorkHistory(ApplicantWorkHistoryPoco[] items)
        {
            _applicantworkhistorylogic.Delete(items);
        }

        public void UpdateApplicantEducation(ApplicantEducationPoco[] items)
        {
            _applicanteducationlogic.Update(items);
        }

        public void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] items)
        {
            _applicantjobapplicationlogic.Update(items);
        }

        public void UpdateApplicantProfile(ApplicantProfilePoco[] items)
        {
            _applicantprofilelogic.Update(items);
        }

        public void UpdateApplicantResume(ApplicantResumePoco[] items)
        {
            _applicantresumelogic.Update(items);
        }

        public void UpdateApplicantSkill(ApplicantSkillPoco[] items)
        {
            _applicantskilllogic.Update(items);
        }

        public void UpdateApplicantWorkHistory(ApplicantWorkHistoryPoco[] items)
        {
            _applicantworkhistorylogic.Update(items);
        }
    }
}
