using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyJobDescriptionLogic : BaseLogic<CompanyJobDescriptionPoco>
    {
        public CompanyJobDescriptionLogic(IDataRepository<CompanyJobDescriptionPoco> repository) : base(repository)
        {

        }
        public override void Add(CompanyJobDescriptionPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }
        public override void Update(CompanyJobDescriptionPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }
        protected override void Verify(CompanyJobDescriptionPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            foreach (CompanyJobDescriptionPoco item in pocos)
            {
                if ((item.JobName ==string.Empty) || (item.JobName is null))
                {
                    exceptions.Add(new ValidationException(300, $"JobName for CompanyJobDescriptionLogin {item.Id} cannot be null or empty."));
                }
                if ((item.JobDescriptions ==string.Empty) || (item.JobDescriptions is null))
                {
                    exceptions.Add(new ValidationException(301, $"JobDescriptions for CompanyJobDescriptionLogin {item.Id} cannot be null or empty."));
                }                
            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
