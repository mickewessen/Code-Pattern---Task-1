using Code_Pattern___Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Model
{
    public class ReturnDataCustomers
    {

        public void ReturnCustomerData(List<ICustomer> customerList)
        {
            Console.Clear();
            if (customerList.Count == 0)
            {
                Console.WriteLine("There are no customers registered yet, press enter to go back to main menu");
                Console.Read();
            }
            else
            {
                foreach (var customer in customerList)
                {
                    if (customer.customerAnimals == null)
                    {
                        var message = "No animal";
                        Console.WriteLine($"Customer: {customer.FirstName} {customer.LastName} - Phonenumber: +46{customer.PhoneNumber}, {message}");
                    }
                    else
                    {
                        Console.WriteLine($"Customer: {customer.FirstName} {customer.LastName} - Phonenumber: +46{customer.PhoneNumber}, {customer.customerAnimals.Name}");
                    }

                }
                Console.WriteLine("Press any key to return to menu");
                Console.Read();
            }            
        }

    }
}
