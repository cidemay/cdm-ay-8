using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class FirmaManager
    {
        public void GiveData(Person person)
        {
            PersonManager personManager = new PersonManager();

            if (personManager.checkPerson(person))
            {
                Console.WriteLine(person.FirstName + "" + person.LastName + "" + "gecerli vatandaş bilgisine sahiptir.");
            }

        }
    }
}
