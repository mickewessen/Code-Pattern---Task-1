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
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public IAnimal customerAnimal { get; set; }

        public void RegisterCustomer()
        {
            Console.WriteLine("Enter your first name");
            Console.ReadLine();
            Console.WriteLine("Enter your last name");
            Console.ReadLine();
            Console.WriteLine("Enter your phonenumber");
            Console.ReadLine();
            Console.WriteLine("Customer saved - press any key");
            Console.Read();
        }
    }
}
