﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;


namespace CareerCloud.BusinessLogicLayer
{
    public class SystemLanguageCodeLogic 
    {
        protected IDataRepository<SystemLanguageCodePoco> _repository;
        public SystemLanguageCodeLogic(IDataRepository<SystemLanguageCodePoco> repository)
        {
            _repository = repository;
        }

        protected void Verify(SystemLanguageCodePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            foreach (SystemLanguageCodePoco item in pocos)
            {
                if (item.LanguageID== string.Empty)
                {
                    exceptions.Add(new ValidationException(1000, $"LanguageID for SystemLanguageCodeLogin {item.LanguageID} cannot be empty."));
                }
                if (item.Name == string.Empty)
                {
                    exceptions.Add(new ValidationException(1001, $"Name for SystemLanguageCodeLogin {item.LanguageID} cannot be empty."));
                }
                if (item.NativeName == string.Empty)
                {
                    exceptions.Add(new ValidationException(1002, $"NativeName for SystemLanguageCodeLogin {item.LanguageID} cannot be empty."));
                }

            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }

        public SystemLanguageCodePoco Get(String LanguageID)
        {
            return _repository.GetSingle(c => c.LanguageID == LanguageID);
        }

        public List<SystemLanguageCodePoco> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public void Add(SystemLanguageCodePoco[] pocos)
        {
            Verify(pocos);
            _repository.Add(pocos);
        }

        public void Update(SystemLanguageCodePoco[] pocos)
        {
            Verify(pocos);
            _repository.Update(pocos);
        }

        public void Delete(SystemLanguageCodePoco[] pocos)
        {
            _repository.Remove(pocos);
        }


    }
}
