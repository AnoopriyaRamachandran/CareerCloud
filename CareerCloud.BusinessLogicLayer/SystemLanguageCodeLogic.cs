using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class SystemLanguageCodeLogic<TPoco> where TPoco : SystemLanguageCodePoco
    {
        protected IDataRepository<TPoco> _repository;
        public SystemLanguageCodeLogic(IDataRepository<TPoco> repository)
        {
            _repository = repository;
        }

        protected void Verify(TPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            foreach (SystemLanguageCodePoco item in pocos)
            {
                if (item.LanguageID == string.Empty)
                {
                    exceptions.Add(new ValidationException(1000, "{item.LanguageID}"));
                }
                if (item.Name == string.Empty)
                {
                    exceptions.Add(new ValidationException(1001, "{item.LanguageID}"));
                }
                if (item.NativeName == string.Empty)
                {
                    exceptions.Add(new ValidationException(1002, "{item.LanguageID}"));
                }

            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }

        public TPoco Get(String LanguageID)
        {
            return _repository.GetSingle(c => c.LanguageID == LanguageID);
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
