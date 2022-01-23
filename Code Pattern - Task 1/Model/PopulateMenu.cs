using Code_Pattern___Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Model
{
    public class PopulateMenu : IPopulateMenu
    {
        public ICustomer customer;
        public CustomerService customerService;
        public IMenu menu;
        public IAnimal animal;
        public AnimalService animalService;
        public DummyData dummydata;
        public ReturnDataAnimals returnAnimals;
        public ReturnDataCustomers returnCustomers;
        public ReturnDataServices returnServices;
        public RecieptService recieptService;

        public PopulateMenu(CustomerService customerService, IMenu menu, AnimalService animalService, DummyData dummydata, ReturnDataAnimals returnAnimals, ReturnDataCustomers returnCustomers, ReturnDataServices returnServices, RecieptService recieptService)
        {

            this.customerService = customerService;
            this.menu = menu;
            this.animalService = animalService;
            this.dummydata = dummydata;
            this.returnAnimals = returnAnimals;
            this.returnCustomers = returnCustomers;
            this.returnServices = returnServices;
            this.recieptService = recieptService;
        }

        public void Run()
        {
            List<ICustomer> customerList = new();
            customerList = dummydata.PopulateDummyDataCustomer(customerList);
            List<IAnimal> animalList = new();
            animalList = dummydata.PopulateDummyDataAnimal(animalList);
            List<IAnimalExtraServices> serviceList = new();
            serviceList = dummydata.PopulateDummyDataServices(serviceList);

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
                        //Register a customer
                        customerList = customerService.RegisterCustomer(customerList);
                        return true;

                    case "2":
                        //Register an animal
                        animalList = animalService.RegisterAnimal(animalList);
                        return true;

                    case "3":
                        //Show all Customers
                        returnCustomers.ReturnCustomerData(customerList);
                        return true;

                    case "4":
                        //Show all Animals
                        returnAnimals.ReturnAnimalData(animalList);
                        return true;

                    case "5":
                        //Binds a customer to a animal
                        customerService.ConnectCustomerToAnimal(animalList, customerList);
                        return true;

                    case "6":
                        //Check in animals
                        animalService.CheckInAnimal(animalList);
                        return true;

                    case "7":
                        //Check out animals
                        animalService.CheckOutAnimal(animalList);
                        return true;

                    case "8":
                        //Return a list of all checked in animals
                        returnAnimals.ReturnAnimalDataCheckedInStatus(animalList);
                        return true;
                    case "9":
                        //Add services to animal
                        animalService.AddServicesToAnimal(serviceList, animalList);
                        return true;
                    case "10":
                        //Get reciept for checked out animal
                        recieptService.GetAllReciepts(customerList);
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
