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

        public ICustomer customer;
        public CustomerService customerService;
        public IMenu menu;
        public IAnimal animal;
        public AnimalService animalService;
        public DummyData dummydata;
        public ReturnData returnData;

        public Application(IMenu menu, IAnimal animal, ICustomer customer, DummyData dummydata, ReturnData returnData, CustomerService customerService, AnimalService animalService)
        {
            this.menu = menu;
            this.animal = animal;
            this.customer = customer;
            this.dummydata = dummydata;
            this.returnData = returnData;
            this.customerService = customerService;
            this.animalService = animalService;
        }


        public void Run()
        {
            List<ICustomer> customerList = new();
            customerList = dummydata.PopulateDummyDataCustomer(customerList);
            List<IAnimal> animalList = new();
            animalList = dummydata.PopulateDummyDataAnimal(animalList);
            List<IReciept> recieptList = new();
            recieptList = dummydata.PopulateDummyDataReciept(recieptList);
          
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
                        customerList = customerService.RegisterCustomer(customerList);
                        return true;

                    case "2":
                        animalList = animalService.RegisterAnimal(animalList); 
                        return true;

                    case "3":
                        returnData.ReturnCustomerData(customerList);
                        return true;

                    case "4":
                        returnData.ReturnAnimalData(animalList);
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
                        returnData.ReturnRecieptData(recieptList);
                        return true;
                    case "10":
                        return false;
                    default:
                        return true;
                }
            }
        }

    }
}
