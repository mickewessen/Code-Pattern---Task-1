using Code_Pattern___Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Model
{
    public class RecieptService
    {
        public void GetAllReciepts(List<ICustomer> customerList)
        {
            Console.WriteLine("Please choose a customer");
            foreach (var customer in customerList)
            {
                Console.WriteLine($"{customer.FirstName} {customer.LastName}");
            }

            var customerInput = Console.ReadLine();
            Int32.TryParse(customerInput, out int customerOutput);
            var choosenCustomer = customerList[customerOutput - 1];
            Console.Clear();

            if (choosenCustomer.customerAnimals == null)
            {
                Console.WriteLine("This customer has no pets");
                Console.WriteLine("Press enter to go back to menu");
                Console.Read();             
            }
            else 
            {
                Console.WriteLine($"Date & Time {DateTime.Now}");
                Console.WriteLine($"Petname: {choosenCustomer.customerAnimals.Name}");
                Console.WriteLine($"Petstatus: {choosenCustomer.customerAnimals.IsCheckedIn = "Checked out"}");
                if (choosenCustomer.customerAnimals.extraServiceList == null)
                {
                    Console.WriteLine($"Extra services: 0kr");
                    decimal totalPrice = 100;
                    Console.WriteLine($"Totalprice: {totalPrice}kr ");
                }
                else
                {
                    Console.WriteLine("Extra services");
                    foreach (var item in choosenCustomer.customerAnimals.extraServiceList)
                    {
                        Console.WriteLine($"{item.NameOfService} {item.PriceOfService}kr");
                    }
                    Console.WriteLine($"Price per day: 100kr");

                    decimal totalPrice = 0;

                    foreach (var serviceCost in choosenCustomer.customerAnimals.extraServiceList)
                    {
                        totalPrice += serviceCost.PriceOfService;
                    }

                    Console.WriteLine($"Totalprice: {totalPrice+100}kr");                    
                }
                Console.Read();
            }
        }
    }
}
