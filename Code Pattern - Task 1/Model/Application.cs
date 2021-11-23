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
        public RecieptService recieptService;

        public Application(IMenu menu, IAnimal animal, ICustomer customer, DummyData dummydata, ReturnData returnData, CustomerService customerService, AnimalService animalService, RecieptService recieptService)
        {
            this.menu = menu;
            this.animal = animal;
            this.customer = customer;
            this.dummydata = dummydata;
            this.returnData = returnData;
            this.customerService = customerService;
            this.animalService = animalService;
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



            #region Menu with arrows (not working :/)
            //string prompt = "Dog Kennel";
            //string[] options =
            //{
            //    "Choose an option:",
            //    "Register new customer",
            //    "Register new animal",
            //    "Show all customers",
            //    "Show all animals",
            //    "Customers animals",
            //    "Check IN animals",
            //    "Check OUT animals",
            //    "List of animals checked in",
            //    "Services",
            //    "Receipt",
            //    "Exit",
            //};
            //TestMenu testMenu = new TestMenu(options, prompt);
            //int selectedIndex = testMenu.Run();


            //switch (selectedIndex)
            //{
            //    case 1:
            //        Console.Clear();
            //        customerList = customerService.RegisterCustomer(customerList);
            //        Console.WriteLine("Press any key to return to the menu");
            //        Console.ReadKey(true);
            //        testMenu.Run();
            //        break;

            //    case 2:
            //        Console.Clear();
            //        animalList = animalService.RegisterAnimal(animalList);
            //        Console.WriteLine("Press any key to return to the menu");
            //        Console.ReadKey(true);
            //        testMenu.Run();
            //        break;

            //    case 3:
            //        Console.Clear();
            //        returnData.ReturnCustomerData(customerList);                    
            //        Console.WriteLine("Press any key to return to the menu");
            //        Console.ReadKey(true);
            //        testMenu.Run();
            //        break;

            //    case 4:
            //        Console.Clear();
            //        returnData.ReturnAnimalData(animalList);
            //        Console.WriteLine("Press any key to return to the menu");
            //        Console.ReadKey(true);
            //        testMenu.Run();
            //        break;

            //    case 5:
            //        break;

            //    case 6:
            //        //Check in animal
            //        Console.Clear();
            //        animalService.CheckInAnimal(animalList);
            //        Console.WriteLine("Press any key to return to the menu");
            //        Console.ReadKey(true);
            //        testMenu.Run();
            //        break;

            //    case 7:
            //        //Check out animal
            //        Console.Clear();
            //        animalService.CheckOutAnimal(animalList);
            //        Console.WriteLine("Press any key to return to the menu");
            //        Console.ReadKey(true);
            //        testMenu.Run();
            //        break;

            //    case 8:
            //        Console.Clear();
            //        returnData.ReturnAnimalDataCheckedInStatus(animalList);
            //        Console.WriteLine("Press any key to return to the menu");
            //        Console.ReadKey(true);
            //        testMenu.Run();
            //        break;

            //    case 9:
            //        //Add services
            //        break;

            //    case 10:
            //        Console.Clear();
            //        returnData.ReturnRecieptData(recieptList);
            //        Console.WriteLine("Press any key to return to the menu");
            //        Console.ReadKey(true);
            //        testMenu.Run();
            //        break;
            //    case 11:
            //        Environment.Exit(0);
            //        break;

            //}

            #endregion ()

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
                        returnData.ReturnCustomerData(customerList);
                        return true;

                    case "4":
                        //Show all Animals
                        returnData.ReturnAnimalData(animalList);
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
                        returnData.ReturnAnimalDataCheckedInStatus(animalList);
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
