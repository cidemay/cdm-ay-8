using Business.Abstract;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantService
    {
        public void Apply(Person person)
        {
            throw new NotImplementedException();
        }

        public bool checkPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
