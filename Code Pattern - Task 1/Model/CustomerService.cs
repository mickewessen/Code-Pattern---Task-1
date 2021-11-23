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
                //Enter firstname and check if input null or whitespace
                Console.Clear();
                Console.WriteLine("Enter your first name");
                var fname = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(fname))
                {
                    Console.WriteLine("Firstname cannot be empty, try again");
                    fname = Console.ReadLine();
                }
                customer.FirstName = fname;

                //Enter lastname and check if input null or whitespace
                Console.Clear();
                Console.WriteLine("Enter your last name");
                var lname = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(lname))
                {
                    Console.WriteLine("Lastname cannot be empty, try again");
                    lname = Console.ReadLine();
                }
                customer.LastName = lname;

                //Check if phonenumber is an int and not null
                Console.Clear();
                Console.WriteLine("Enter your phonenumber");
                var phoneNumberAsString = Console.ReadLine();
                int phoneNumber;
                while (!int.TryParse(phoneNumberAsString, out phoneNumber))
                {
                    Console.WriteLine("Invalid input, please enter a valid phonenumber");
                    phoneNumberAsString = Console.ReadLine();                   
                }
                customers.Add(customer);
            }
            Console.WriteLine("Customer saved - press any key");
            Console.Read();
            return customers;
        }

        //Connect a animal to a customer
        public void ConnectCustomerToAnimal(List<IAnimal> animalList, List<ICustomer> customerList)
        {
            Console.Clear();
            Console.WriteLine("Please pick a customer");    

            foreach (var customer in customerList)
            {
                Console.WriteLine($"{customer.FirstName}, {customer.LastName}");
            }

            var customerInput = Console.ReadLine();
            Int32.TryParse(customerInput, out int customerOutput);
            var choosenCustomer = customerList[customerOutput - 1];

            Console.Clear();
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
