using Business.Abstract;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PersonManager:IApplicantService
    {
        public void Apply(Person person)
        {

        }
        public List<Person>GetList()
        {
            return null;
        }

        public bool checkPerson(Person person)
        {
            return true;
        }

    }
}
