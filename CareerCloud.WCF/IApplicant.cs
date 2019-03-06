using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CareerCloud.WCF
{
   
    [ServiceContract]
    public interface IApplicant
    {
        //ApplicantEducationPoco

        [OperationContract]
        void AddApplicantEducation(ApplicantEducationPoco[] item);
        [OperationContract]
        List<ApplicantEducationPoco> GetAllApplicantEducation();
        [OperationContract]
        ApplicantEducationPoco GetSingleApplicantEducation(Guid id);
        [OperationContract]
        void RemoveApplicantEducation(Guid id);
        [OperationContract]
        void UpdateApplicantEducation(ApplicantEducationPoco[] items);

        //ApplicantJobApplicationPoco

        [OperationContract]
        void AddApplicantJobApplication(ApplicantJobApplicationPoco[] item);
        [OperationContract]
        List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication();
        [OperationContract]
        ApplicantJobApplicationPoco GetSingleApplicantJobApplication(Guid id);
        [OperationContract]
        void RemoveApplicantJobApplication(Guid id);
        [OperationContract]
        void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] items);

        //ApplicantProfilePoco

        [OperationContract]
        void AddApplicantProfile(ApplicantProfilePoco[] item);
        [OperationContract]
        List<ApplicantProfilePoco> GetAllApplicantProfile();
        [OperationContract]
        ApplicantProfilePoco GetSingleApplicantProfile(Guid id);
        [OperationContract]
        void RemoveApplicantProfile(Guid id);
        [OperationContract]
        void UpdateApplicantProfile(ApplicantProfilePoco[] items);

        //ApplicantResumePoco

        [OperationContract]
        void AddApplicantResume(ApplicantResumePoco[] item);
        [OperationContract]
        List<ApplicantResumePoco> GetAllApplicantResume();
        [OperationContract]
        ApplicantResumePoco GetSingleApplicantResume(Guid id);
        [OperationContract]
        void RemoveApplicantResume(Guid id);
        [OperationContract]
        void UpdateApplicantResume(ApplicantResumePoco[] items);

        //ApplicantSkillPoco

        [OperationContract]
        void AddApplicantSkill(ApplicantSkillPoco[] item);
        [OperationContract]
        List<ApplicantSkillPoco> GetAllApplicantSkill();
        [OperationContract]
        ApplicantSkillPoco GetSingleApplicantSkill(Guid id);
        [OperationContract]
        void RemoveApplicantSkill(Guid id);
        [OperationContract]
        void UpdateApplicantSkill(ApplicantSkillPoco[] items);

        //ApplicantWorkHistoryPoco

        [OperationContract]
        void AddApplicantWorkHistory(ApplicantWorkHistoryPoco[] item);
        [OperationContract]
        List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory();
        [OperationContract]
        ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(Guid id);
        [OperationContract]
        void RemoveApplicantWorkHistory(Guid id);
        [OperationContract]
        void UpdateApplicantWorkHistory(ApplicantWorkHistoryPoco[] items);

    }


}
