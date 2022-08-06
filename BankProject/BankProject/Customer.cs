using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject
{
    public class Customer
    {

        public int Code { get; set; }

        public long NationalIdentity { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public long Phone { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public double CreditNote { get; set; }
    }
}
