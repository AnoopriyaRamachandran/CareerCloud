using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyProfileLogic : BaseLogic<CompanyProfilePoco>
    {
        public CompanyProfileLogic(IDataRepository<CompanyProfilePoco> repository) : base(repository)
        {

        }
        public override void Add(CompanyProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }
        public override void Update(CompanyProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }
        protected override void Verify(CompanyProfilePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            foreach (CompanyProfilePoco item in pocos)
            {
                string[] phoneComponents = item.ContactPhone.Split('-');
                if (item.CompanyWebsite < 3)
                {
                    exceptions.Add(new ValidationException(600, "{item.Id}"));
                }                
                if (phoneComponents.Length < 3)
                {
                    exceptions.Add(new ValidationException(601, $"ContactPhoneNumber for CompanyProfileLogin {item.Id} is not in the required format."));
                }
                else
                {
                    if (phoneComponents[0].Length < 3)
                    {
                        exceptions.Add(new ValidationException(601, $"ContactPhoneNumber for CompanyProfileLogin {item.Id} is not in the required format."));
                    }
                    else if (phoneComponents[1].Length < 3)
                    {
                        exceptions.Add(new ValidationException(601, $"ContactPhoneNumber for CompanyProfileLogin {item.Id} is not in the required format."));
                    }
                    else if (phoneComponents[2].Length < 4)
                    {
                        exceptions.Add(new ValidationException(601, $"ContactPhoneNumber for CompanyProfileLogin {item.Id} is not in the required format."));
                    }
                }
                
            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
