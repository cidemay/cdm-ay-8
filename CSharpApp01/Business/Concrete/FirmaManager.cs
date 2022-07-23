using Business.Abstract;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class FirmaManager:ISupplierService
    {
       
         private IApplicantService _applicantService;

        public FirmaManager (IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public void GiveData(Person person)
        {

            if (_applicantService.checkPerson(person))
            {
                Console.WriteLine(person.FirstName + "" + person.LastName + "" + "gecerli vatandaş bilgisine sahiptir.");
            }

        }
    }
}
