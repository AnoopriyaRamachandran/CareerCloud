using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class SecurityLoginPoco : IPoco
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? PasswordUpdateDate { get; set; }
        public DateTime? AgreementAcceptedDate { get; set; }
        public Boolean IsLocked { get; set; }
        public Boolean IsInactive { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public Boolean ForceChangePassword { get; set; }
        public string PrefferredLanguage { get; set; }
        public byte[] TimeStamp { get; set; }

    }
}
