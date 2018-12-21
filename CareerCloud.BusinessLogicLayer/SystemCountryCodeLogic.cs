using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class SystemCountryCodeLogic<TPoco> where TPoco : SystemCountryCodePoco
    {
        protected IDataRepository<TPoco> _repository;
        public SystemCountryCodeLogic(IDataRepository<TPoco> repository)
        {
            _repository = repository;
        }

        protected void Verify(TPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            foreach (SystemCountryCodePoco item in pocos)
            {
                if (item.Code == string.Empty)
                {
                    exceptions.Add(new ValidationException(900, "{item.Code}"));
                }
                if (item.Name == string.Empty)
                {
                    exceptions.Add(new ValidationException(901, "{item.Code}"));
                }
                
            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }

        public TPoco Get(String code)
        {
            return _repository.GetSingle(c => c.Code == code);
        }

        public List<TPoco> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public void Add(TPoco[] pocos)
        {
            Verify(pocos);
            _repository.Add(pocos);
        }

        public void Update(TPoco[] pocos)
        {
            Verify(pocos);
            _repository.Update(pocos);
        }

        public void Delete(TPoco[] pocos)
        {
            _repository.Remove(pocos);
        }


    }
}
