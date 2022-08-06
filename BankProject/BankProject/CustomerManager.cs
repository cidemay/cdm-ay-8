using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject
{
    public class CustomerManager
    {
        public int CustomerCredit(Customer customer)
        {
            //Credit Note: 0-10 arasında olabilir.
            int creditAmount;

            if (customer.CreditNote>=8)
            {
                creditAmount = 30000;
            }

            else if (customer.CreditNote >= 5 && customer.CreditNote < 8)
            {
                creditAmount = 20000;
            }

            else if (customer.CreditNote >= 2 && customer.CreditNote < 5)
            {
                creditAmount = 7000;
            }

            else
            {
                creditAmount = 0;
            }

            return creditAmount;
        }

    }
}
