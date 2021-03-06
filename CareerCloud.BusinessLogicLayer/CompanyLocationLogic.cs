﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyLocationLogic : BaseLogic<CompanyLocationPoco>
    {
        public CompanyLocationLogic(IDataRepository<CompanyLocationPoco> repository) : base(repository)
        {

        }
        public override void Add(CompanyLocationPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }
        public override void Update(CompanyLocationPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }
        protected override void Verify(CompanyLocationPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            foreach (CompanyLocationPoco item in pocos)
            {
                if (string.IsNullOrEmpty(item.CountryCode))
                {
                    exceptions.Add(new ValidationException(500, $"CountryCode for CompanyLocationLogin {item.Id} cannot be empty."));
                }
                if (string.IsNullOrEmpty(item.Province))
                {
                    exceptions.Add(new ValidationException(501, $"Province for CompanyLocationLogin {item.Id} cannot be empty."));
                }
                if (string.IsNullOrEmpty(item.Street))
                {
                    exceptions.Add(new ValidationException(502, $"Street for CompanyLocationLogin {item.Id} cannot be empty."));
                }
                if(string.IsNullOrEmpty(item.City))
                {
                    exceptions.Add(new ValidationException(503, $"City for CompanyLocationLogin {item.Id} cannot be empty."));
                }
                if(string.IsNullOrEmpty(item.PostalCode))
                {
                    exceptions.Add(new ValidationException(504, $"PostalCode for CompanyLocationLogin {item.Id} cannot be empty."));
                }
            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
