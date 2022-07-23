using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.concrete
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int DateOfBirthYear { get; set; }

        public long NationalIdentity { get; set; }
    }
}
