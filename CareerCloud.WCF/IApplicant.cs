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
        ApplicantEducationPoco GetSingleApplicantEducation(string id);
        [OperationContract]
        void RemoveApplicantEducation(ApplicantEducationPoco[] items);
        [OperationContract]
        void UpdateApplicantEducation(ApplicantEducationPoco[] items);

        //ApplicantJobApplicationPoco

        [OperationContract]
        void AddApplicantJobApplication(ApplicantJobApplicationPoco[] item);
        [OperationContract]
        List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication();
        [OperationContract]
        ApplicantJobApplicationPoco GetSingleApplicantJobApplication(string id);
        [OperationContract]
        void RemoveApplicantJobApplication(ApplicantJobApplicationPoco[] items);
        [OperationContract]
        void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] items);

        //ApplicantProfilePoco

        [OperationContract]
        void AddApplicantProfile(ApplicantProfilePoco[] item);
        [OperationContract]
        List<ApplicantProfilePoco> GetAllApplicantProfile();
        [OperationContract]
        ApplicantProfilePoco GetSingleApplicantProfile(string id);
        [OperationContract]
        void RemoveApplicantProfile(ApplicantProfilePoco[] items);
        [OperationContract]
        void UpdateApplicantProfile(ApplicantProfilePoco[] items);

        //ApplicantResumePoco

        [OperationContract]
        void AddApplicantResume(ApplicantResumePoco[] item);
        [OperationContract]
        List<ApplicantResumePoco> GetAllApplicantResume();
        [OperationContract]
        ApplicantResumePoco GetSingleApplicantResume(string id);
        [OperationContract]
        void RemoveApplicantResume(ApplicantResumePoco[] items);
        [OperationContract]
        void UpdateApplicantResume(ApplicantResumePoco[] items);

        //ApplicantSkillPoco

        [OperationContract]
        void AddApplicantSkill(ApplicantSkillPoco[] item);
        [OperationContract]
        List<ApplicantSkillPoco> GetAllApplicantSkill();
        [OperationContract]
        ApplicantSkillPoco GetSingleApplicantSkill(string id);
        [OperationContract]
        void RemoveApplicantSkill(ApplicantSkillPoco[] items);
        [OperationContract]
        void UpdateApplicantSkill(ApplicantSkillPoco[] items);

        //ApplicantWorkHistoryPoco

        [OperationContract]
        void AddApplicantWorkHistory(ApplicantWorkHistoryPoco[] item);
        [OperationContract]
        List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory();
        [OperationContract]
        ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(string id);
        [OperationContract]
        void RemoveApplicantWorkHistory(ApplicantWorkHistoryPoco[] items);
        [OperationContract]
        void UpdateApplicantWorkHistory(ApplicantWorkHistoryPoco[] items);

    }


}
