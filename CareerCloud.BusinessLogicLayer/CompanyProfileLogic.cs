using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                
                /*string[] webextension = { "ca", "com", "biz" };
                string userextension = Path.GetExtension(item.CompanyWebsite);
                for(int i=0;i<webextension.Length;i++)
                {
                    if (userextension!=webextension[i])
                    {
                        exceptions.Add(new ValidationException(600, $"CompanyWebsite for CompanyProfileLogin {item.Id} is not a valid website format."));
                    }

                }*/
                if(string.IsNullOrEmpty(item.CompanyWebsite))
                {
                    exceptions.Add(new ValidationException(600, $"CompanyWebsite for CompanyProfileLogin {item.Id} is not a valid website format."));
                }
                else if (!Regex.IsMatch(item.CompanyWebsite, @"^(((ht|f)tp(s?))\://)?(www.|[a-zA-Z].)[a-zA-Z0-9\-\.]+\.(com|ca|biz)(\:[0-9]+)*(/($|[a-zA-Z0-9\.\,\;\?\'\\\+&amp;%\$#\=~_\-]+))*$", RegexOptions.IgnoreCase))

                {
                    exceptions.Add(new ValidationException(600, $"CompanyWebsite for CompanyProfileLogin {item.Id} must end with .ca,.com,.biz extensions"));

                }
                if (string.IsNullOrEmpty(item.ContactPhone))
                {
                    exceptions.Add(new ValidationException(601, $"ContactPhoneNumber for CompanyProfileLogin {item.Id} is required."));

                }
                else
                {
                    string[] phoneComponents = item.ContactPhone.Split('-');
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
            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
