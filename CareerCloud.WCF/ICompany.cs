using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CareerCloud.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICompany" in both code and config file together.
    [ServiceContract]
    public interface ICompany
    {
        //CompanyDescriptionPoco

        [OperationContract]
        void AddCompanyDescription(CompanyDescriptionPoco[] item);
        [OperationContract]
        List<CompanyDescriptionPoco> GetAllCompanyDescription();
        [OperationContract]
        CompanyDescriptionPoco GetSingleCompanyDescription(Guid id);
        [OperationContract]
        void RemoveCompanyDescription(CompanyDescriptionPoco[] items);
        [OperationContract]
        void UpdateCompanyDescription(CompanyDescriptionPoco[] items);

        //CompanyJobDescriptionPoco

        [OperationContract]
        void AddCompanyJobDescription(CompanyJobDescriptionPoco[] item);
        [OperationContract]
        List<CompanyJobDescriptionPoco> GetAllCompanyJobDescription();
        [OperationContract]
        CompanyJobDescriptionPoco GetSingleCompanyJobDescription(Guid id);
        [OperationContract]
        void RemoveCompanyJobDescription(CompanyJobDescriptionPoco[] items);
        [OperationContract]
        void UpdateCompanyJobDescription(CompanyJobDescriptionPoco[] items);

        //CompanyJobEducationPoco

        void AddCompanyJobEducation(CompanyJobEducationPoco[] item);
        [OperationContract]
        List<CompanyJobEducationPoco> GetAllCompanyJobEducation();
        [OperationContract]
        CompanyJobEducationPoco GetSingleCompanyJobEducation(Guid id);
        [OperationContract]
        void RemoveCompanyJobEducation(CompanyJobEducationPoco[] items);
        [OperationContract]
        void UpdateCompanyJobEducation(CompanyJobEducationPoco[] items);

        //CompanyJobPoco

        void AddCompanyJob(CompanyJobPoco[] item);
        [OperationContract]
        List<CompanyJobPoco> GetAllCompanyJob();
        [OperationContract]
        CompanyJobPoco GetSingleCompanyJob(Guid id);
        [OperationContract]
        void RemoveCompanyJob(CompanyJobPoco[] items);
        [OperationContract]
        void UpdateCompanyJob(CompanyJobPoco[] items);

        //CompanyJobSkillPoco

        void AddCompanyJobSkill(CompanyJobSkillPoco[] item);
        [OperationContract]
        List<CompanyJobSkillPoco> GetAllCompanyJobSkill();
        [OperationContract]
        CompanyJobSkillPoco GetSingleCompanyJobSkill(Guid id);
        [OperationContract]
        void RemoveCompanyJobSkill(CompanyJobSkillPoco[] items);
        [OperationContract]
        void UpdateCompanyJobSkill(CompanyJobSkillPoco[] items);

        //CompanyLocationPoco

        void AddCompanyLocation(CompanyLocationPoco[] item);
        [OperationContract]
        List<CompanyLocationPoco> GetAllCompanyLocation();
        [OperationContract]
        CompanyLocationPoco GetSingleCompanyLocation(Guid id);
        [OperationContract]
        void RemoveCompanyLocation(CompanyLocationPoco[] items);
        [OperationContract]
        void UpdateCompanyLocation(CompanyLocationPoco[] items);

        //CompanyProfilePoco

        void AddCompanyProfile(CompanyProfilePoco[] item);
        [OperationContract]
        List<CompanyProfilePoco> GetAllCompanyProfile();
        [OperationContract]
        CompanyProfilePoco GetSingleCompanyProfile(Guid id);
        [OperationContract]
        void RemoveCompanyProfile(CompanyProfilePoco[] items);
        [OperationContract]
        void UpdateCompanyProfile(CompanyProfilePoco[] items);


    }
}
