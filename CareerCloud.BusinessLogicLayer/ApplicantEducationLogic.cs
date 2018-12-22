using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    
    public class ApplicantEducationLogic : BaseLogic<ApplicantEducationPoco>
    {

        public ApplicantEducationLogic(IDataRepository<ApplicantEducationPoco> repository) : base(repository)
        {
        }
        public override void Add(ApplicantEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }
        public override void Update(ApplicantEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }
        protected override void Verify(ApplicantEducationPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            foreach(ApplicantEducationPoco item in pocos)
            {
                if(item.Major.Length <3)
                {
                    exceptions.Add(new ValidationException(107, $"Major Length for ApplicationEducationLogin {item.Id} cannot be less than 3 or empty."));
                }
                if(item.StartDate>DateTime.Now)
                {
                    exceptions.Add(new ValidationException(108, $"StartDate for ApplicationEducationLogin {item.Id} Cannot be greater than today's date."));
                }
                if (item.CompletionDate < item.StartDate)
                {
                    exceptions.Add(new ValidationException(109, $"CompletionDate for ApplicationEducationLogin {item.Id} cannot be earlier than StartDate."));
                }
            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
