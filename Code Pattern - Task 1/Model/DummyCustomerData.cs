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
        public void ReturnCustomerData()
        {
            List<ICustomer> customerList = new List<ICustomer>
            {
                new Customer { ID = 1, FirstName = "Micke", LastName = "Wessén", PhoneNumber = 0738142090/*, customerAnimal={ID=1,Name="test"}*/},
                new Customer { ID = 2, FirstName = "Samuel", LastName = "Wessén", PhoneNumber = 0738142091/*, customerAnimal={ ID=2, Name="test2"} */},
                new Customer { ID = 3, FirstName = "Daniel", LastName = "Wessén", PhoneNumber = 0738142092/*, customerAnimal={ ID=3, Name="test3"} */}
            };

            foreach (var customer in customerList)
            {
                Console.WriteLine($"{customer.ID} - {customer.FirstName} {customer.LastName} - {customer.PhoneNumber}");
            }
            Console.Read();
        }

    }
}
