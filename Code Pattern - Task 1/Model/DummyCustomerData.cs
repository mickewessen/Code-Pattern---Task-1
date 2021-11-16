using Code_Pattern___Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Model
{
    public class DummyCustomerData
    {
        public void ReturnCustomerData(List<ICustomer> customerList)
        {           

            foreach (var customer in customerList)
            {
                Console.WriteLine($"{customer.FirstName} {customer.LastName} - {customer.PhoneNumber}");
            }
            Console.Read();
        }

    }
}
