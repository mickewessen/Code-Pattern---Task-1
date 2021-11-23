using Code_Pattern___Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Model
{
    public class ReturnData
    {
        public void ReturnAnimalData(List<IAnimal> animalList)
        {
            foreach (var animal in animalList)
            {                
                Console.WriteLine($"Petname: {animal.Name} - Type of pet: {animal.TypeOfAnimal} - Status: {animal.IsCheckedIn}" );
            }
            Console.WriteLine("Press any key to return to menu");
            Console.Read();
        }

        public void ReturnAnimalDataCheckedInStatus(List<IAnimal> animalList)
        {
            foreach (var animal in animalList.Where(x=>x.IsCheckedIn== "Checked in"))
            {
                Console.WriteLine($"Petname: {animal.Name} - Type of pet: {animal.TypeOfAnimal} - Status: {animal.IsCheckedIn}");
            }
            Console.WriteLine("Press any key to return to menu");
            Console.Read();
        }

        public void ReturnCustomerData(List<ICustomer> customerList)
        {
            foreach (var customer in customerList)
            {
                if(customer.customerAnimals == null)
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

        public void ReturnAnimalServiceData(List<IAnimalExtraServices> serviceList)
        {
            foreach (var service in serviceList)
            {
                Console.WriteLine($"Service: {service.NameOfService} - Price: {service.PriceOfService}");
            }
            Console.WriteLine("Press any key to return to menu");
            Console.Read();
        }

    }
}
