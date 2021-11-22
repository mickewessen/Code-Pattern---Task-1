using Code_Pattern___Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Model
{
    public class CustomerService
    {
        //Register and save a new User to a list 
        public List<ICustomer> RegisterCustomer(List<ICustomer> customers)
        { 
            {
                var customer = new Customer();
                Console.WriteLine("Enter your first name");
                customer.FirstName = Console.ReadLine();
                Console.WriteLine("Enter your last name");
                customer.LastName = Console.ReadLine();
                Console.WriteLine("Enter your phonenumber");
                customer.PhoneNumber = Convert.ToInt32(Console.ReadLine());        
                customers.Add(customer);
            }
            Console.WriteLine("Customer saved - press any key");
            Console.Read();
            return customers;
        }

        //Connect a animal to a customer
        public void ConnectCustomerToAnimal(List<IAnimal> animalList, List<ICustomer> customerList)
        {
            Console.WriteLine("Please pick a customer");
            foreach (var customer in customerList)
            {
                Console.WriteLine($"{customer.FirstName}, {customer.LastName}");
            }

            var customerInput = Console.ReadLine();
            Int32.TryParse(customerInput, out int customerOutput);
            var choosenCustomer = customerList[customerOutput - 1];

            Console.WriteLine("Please pick a animal");
            foreach (var animal in animalList)
            {
                Console.WriteLine($"{animal.Name}, {animal.TypeOfAnimal}");
            }
            var animalinput = Console.ReadLine();
            Int32.TryParse(animalinput, out int animaloutput);
            var choosenAnimal = animalList[animaloutput - 1];

            //Sets the choosen customer to the choosen animal
            choosenCustomer.customerAnimals = choosenAnimal;

            Console.WriteLine($"Data saved: {choosenCustomer.FirstName} {choosenCustomer.LastName} is now connected with {choosenAnimal.Name}");
            Console.WriteLine("Press any key to return to main menu");
            Console.Read();
        }

    }
}
