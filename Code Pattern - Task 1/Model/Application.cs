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
        public Application(IMenu menu, IAnimal animal, ICustomer customer, DummyCustomerData customerData, DummyAnimalData animalData)
        {
            this.menu = menu;
            this.animal = animal;
            this.customer = customer;
            this.customerData = customerData;
            this.animalData = animalData;
        }

        public ICustomer customer { get; set; }
        public IMenu menu { get; set; }
        public IAnimal animal { get; set; }
        public DummyCustomerData customerData { get; set; }
        public DummyAnimalData animalData { get; set; }


        public void Run()
        {
            
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
                        customer.RegisterCustomer();
                        return true;

                    case "2":
                        animal.RegisterAnimal(); 
                        return true;

                    case "3":
                        customerData.ReturnCustomerData();
                        return true;

                    case "4":
                        animalData.ReturnAnimalData();
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
                        return true;
                    case "10":
                        return true;
                    case "11":
                        return false;
                    default:
                        return true;
                }
            }
        }
    }
}
