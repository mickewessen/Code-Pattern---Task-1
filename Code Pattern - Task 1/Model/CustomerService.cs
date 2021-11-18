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
        public AnimalService service;

        public CustomerService(AnimalService service)
        {
            this.service = service;
        }


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

                // Skapar en kund
                // spara kund till list

                // skapar du ett djur
                // spara djur till lista                

                // lista alla kunder
                // välj kund
                // lista alla djur
                // välj djur
                // lägg till valt djur i vald kunds animallist                

                //customer.customerAnimals.Add(service.RegisterAnimal(animals));

                customers.Add(customer);
            }
            Console.WriteLine("Customer saved - press any key");
            Console.Read();
            return customers;
        }

    }
}
