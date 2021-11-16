using Code_Pattern___Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Model
{
    public class Customer : ICustomer
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public List<IAnimal> customerAnimals { get; set; }
        
        public List<ICustomer> RegisterCustomer(List<ICustomer> customers)
        {
            //Register and save a new User to a list   
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
    }
}
