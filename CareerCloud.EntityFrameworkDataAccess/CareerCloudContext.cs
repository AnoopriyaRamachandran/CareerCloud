using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess
{
    class CareerCloudContext : DbContext
    {
        public CareerCloudContext() : base(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString)
        {

                Database.Log= l =>System.Diagnostics.Debug.WriteLine(l);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicantProfilePoco>().HasMany(a => a.ApplicantEducations).WithRequired(e => e.ApplicantProfiles).HasForeignKey(e => e.Applicant);





            modelBuilder.Entity<ApplicantEducationPoco>().Ignore(o => o.TimeStamp);
            modelBuilder.Entity<ApplicantJobApplicationPoco>().Ignore(o => o.TimeStamp);
            modelBuilder.Entity<ApplicantProfilePoco>().Ignore(o => o.TimeStamp);
            modelBuilder.Entity<ApplicantSkillPoco>().Ignore(o => o.TimeStamp);
            modelBuilder.Entity<ApplicantWorkHistoryPoco>().Ignore(o => o.TimeStamp);
            modelBuilder.Entity<CompanyDescriptionPoco>().Ignore(o => o.TimeStamp);
            modelBuilder.Entity<CompanyJobDescriptionPoco>().Ignore(o => o.TimeStamp);
            modelBuilder.Entity<CompanyJobEducationPoco>().Ignore(o => o.TimeStamp);
            modelBuilder.Entity<CompanyJobPoco>().Ignore(o => o.TimeStamp);
            modelBuilder.Entity<CompanyJobSkillPoco>().Ignore(o => o.TimeStamp);
            modelBuilder.Entity<CompanyLocationPoco>().Ignore(o => o.TimeStamp);
            modelBuilder.Entity<CompanyProfilePoco>().Ignore(o => o.TimeStamp);
            modelBuilder.Entity<SecurityLoginPoco>().Ignore(o => o.TimeStamp);
            modelBuilder.Entity<SecurityLoginsRolePoco>().Ignore(o => o.TimeStamp);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ApplicantEducationPoco> ApplicantEducations { get; set; }
        public DbSet<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }
        public DbSet<ApplicantProfilePoco> ApplicantProfiles { get; set; }
        public DbSet<ApplicantResumePoco> ApplicantResumes { get; set; }
        public DbSet<ApplicantSkillPoco> ApplicantSkills { get; set; }
        public DbSet<ApplicantWorkHistoryPoco> ApplicantWorkHistories { get; set; }
        public DbSet<CompanyDescriptionPoco> CompanyDescriptions { get; set; }
        public DbSet<CompanyJobDescriptionPoco> CompanyJobDescriptions { get; set; }
        public DbSet<CompanyJobEducationPoco> CompanyJobEducations { get; set; }
        public DbSet<CompanyJobPoco> CompanyJobs { get; set; }
        public DbSet<CompanyJobSkillPoco> CompanyJobSkills { get; set; }
        public DbSet<CompanyLocationPoco> CompanyLocations { get; set; }
        public DbSet<CompanyProfilePoco> CompanyProfiles { get; set; }
        public DbSet<SecurityLoginPoco> SecurityLogins { get; set; }
        public DbSet<SecurityLoginsLogPoco> SecurityLoginsLogs { get; set; }
        public DbSet<SecurityLoginsRolePoco> SecurityLoginsRoles { get; set; }
        public DbSet<SecurityRolePoco> SecurityRoles { get; set; }
        public DbSet<SystemCountryCodePoco> SystemCountryCodes { get; set; }
        public DbSet<SystemLanguageCodePoco> SystemLanguageCodes { get; set; }
    }
}
