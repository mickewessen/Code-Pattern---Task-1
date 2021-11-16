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
                Console.WriteLine($"Petname: {animal.Name} - Type of pet: {animal.TypeOfAnimal}");
            }            
            Console.Read();
        }

        public void ReturnCustomerData(List<ICustomer> customerList)
        {

            foreach (var customer in customerList)
            {
                Console.WriteLine($"Customer:{customer.FirstName} {customer.LastName} - {customer.PhoneNumber}");
            }
            Console.Read();
        }

        public void ReturnRecieptData(List<IReciept> recieptList)
        {

            foreach (var reciept in recieptList)
            {
                Console.WriteLine($"Date: {reciept.RecieptDate} - Customer: {reciept.Customer} - Pet: {reciept.Animal} - Price: {reciept.Price}kr");
            }
            Console.Read();
        }
    }
}
