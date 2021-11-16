using Code_Pattern___Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Model
{
    public class Application : IApplication
    {
        public Application(IMenu menu, IAnimal animal, ICustomer customer, DummyCustomerData customerData, DummyAnimalData animalData, DummyRecieptData recieptData)
        {
            this.menu = menu;
            this.animal = animal;
            this.customer = customer;
            this.customerData = customerData;
            this.animalData = animalData;
            this.recieptData = recieptData;
        }

        public ICustomer customer { get; set; }
        public IMenu menu { get; set; }
        public IAnimal animal { get; set; }
        public DummyCustomerData customerData { get; set; }
        public DummyAnimalData animalData { get; set; }
        public DummyRecieptData recieptData { get; set; }


        public void Run()
        {
            List<ICustomer> customerList = new();
            customerList = PopulateDummyDataCustomer(customerList);
            List<IAnimal> animalList = new();
            animalList = PopulateDummyDataAnimal(animalList);
          
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

            bool MainMenu()
            {
               
                menu.MenuItems();

                switch (Console.ReadLine())
                {
                    case "1":
                        customerList = customer.RegisterCustomer(customerList);
                        return true;

                    case "2":
                        animalList = animal.RegisterAnimal(animalList); 
                        return true;

                    case "3":
                        customerData.ReturnCustomerData(customerList);
                        return true;

                    case "4":
                        animalData.ReturnAnimalData(animalList);
                        return true;
                    case "5":
                        return true;
                    case "6":
                        return true;
                    case "7":
                        return true;
                    case "8":
                        return true;
                    case "9":
                        recieptData.ReturnRecieptData();
                        return true;
                    case "10":
                        return false;
                    default:
                        return true;
                }
            }
        }

        private List<ICustomer> PopulateDummyDataCustomer(List<ICustomer> customerList)
        {
            customerList.Add(new Customer { FirstName = "Micke", LastName = "Wessén", PhoneNumber = 0738142090});
            return customerList;
        }

        private List<IAnimal> PopulateDummyDataAnimal(List<IAnimal> animalList)
        {
            animalList.Add(new Animal { Name = "Maskot" });
            return animalList;
        }
    }
}
