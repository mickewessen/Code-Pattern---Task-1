using Code_Pattern___Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Model
{
    public class AnimalService
    {

        //Register and save a new Animal to a list   
        public List<IAnimal> RegisterAnimal(List<IAnimal> animals)
        {
            //Add more animaltypes if neeeded!
            List<string> typeofanimal = new()
            {
                "Cat",
                "Dog",
                "Elephant"
            };

            //Add more statuses if needed!
            List<string> checkedInStatus = new()
            {
                "Checked in",
                "Not checked in"
            };


            var animal = new Animal();
            {

                //Check if pets name is null
                Console.Clear();
                Console.WriteLine("Enter the pets name");
                var animalName = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(animalName))
                {
                    Console.WriteLine("Name cannot be empty, try again");
                    animalName = Console.ReadLine();
                }
                animal.Name = animalName;

                //List all pet types!
                Console.Clear();
                Console.WriteLine("Choose which type of animal");
                foreach (var type in typeofanimal)
                {
                    Console.WriteLine($"{type}");
                }


                //Take userinput, check if the number is out of range and convert to int -1 for animal type
                var userInputTypeOfAnimalAsString = Console.ReadLine();
                int userInPutAnimalTypeAsInt;
                while ((!int.TryParse(userInputTypeOfAnimalAsString, out userInPutAnimalTypeAsInt)) ||(userInPutAnimalTypeAsInt > typeofanimal.Count) || (userInPutAnimalTypeAsInt < 0))
                {
                    Console.WriteLine("Please enter a valid number");
                    userInputTypeOfAnimalAsString = Console.ReadLine();
                }
                var chosenAnimal = typeofanimal[userInPutAnimalTypeAsInt - 1];
                animal.TypeOfAnimal = chosenAnimal;

                //Take userinput check if number is out of  range and convert to int -1 for checked in status 
                Console.Clear();
                Console.WriteLine("Do you want to check in the animal?");
                foreach (var status in checkedInStatus)
                {
                    Console.WriteLine($"{status}");
                }

                var userInputCheckedInStatusAsString = Console.ReadLine();
                int userInputCheckedInStatusAsInt;

                while ((!int.TryParse(userInputCheckedInStatusAsString, out userInputCheckedInStatusAsInt)) || (userInputCheckedInStatusAsInt > checkedInStatus.Count) || (userInputCheckedInStatusAsInt < 0))
                {
                    Console.WriteLine("Please enter a valid number");
                    userInputCheckedInStatusAsString = Console.ReadLine();                    
                }
                var statusAnimal = checkedInStatus[userInputCheckedInStatusAsInt - 1];
                animal.IsCheckedIn = statusAnimal;

                animals.Add(animal);
            }
            Console.WriteLine("Animal saved - press any key");
            Console.Read();
            return animals;
        }

        public void CheckOutAnimal(List<IAnimal> animalList)
        {
            Console.Clear();
            Console.WriteLine("Please choose a pet to check out");
            foreach (var checkedInAnimals in animalList.Where(x=>x.IsCheckedIn==("Checked in")))
            {
                Console.WriteLine($"{checkedInAnimals.Name}, {checkedInAnimals.TypeOfAnimal}, {checkedInAnimals.IsCheckedIn}");
            }

            var input = Console.ReadLine();                
            Int32.TryParse(input, out int output);
            var status = animalList[output - 1];
            status.IsCheckedIn = "Not Checked in";
        }

        public void CheckInAnimal(List<IAnimal> animalList)
        {
            Console.WriteLine("Please choose a pet to check in");
            foreach (var notCheckedInAnimals in animalList.Where(x => x.IsCheckedIn == ("Not Checked in")))
            {
                Console.WriteLine($"{notCheckedInAnimals.Name}, {notCheckedInAnimals.TypeOfAnimal}, {notCheckedInAnimals.IsCheckedIn}");
            }
            var input = Console.ReadLine();
            Int32.TryParse(input, out int output);
            var status = animalList[output - 1];
            status.IsCheckedIn = "Checked in";
        }

        public void AddServicesToAnimal(List<IAnimalExtraServices> serviceList, List<IAnimal> animalList)
        {
            Console.WriteLine("Please pick a animal");
            foreach (var animal in animalList)
            {
                Console.WriteLine($"{animal.Name}, {animal.TypeOfAnimal}");
            }
            var animalinput = Console.ReadLine();
            Int32.TryParse(animalinput, out int animaloutput);
            var choosenAnimal = animalList[animaloutput - 1];

            Console.WriteLine("Please pick a service to add to your pet");
            foreach (var service in serviceList)
            {
                Console.WriteLine($"{service.NameOfService}, {service.PriceOfService}");
            }
            var serviceInput = Console.ReadLine();
            Int32.TryParse(serviceInput, out int serviceOutput);
            var choosenService = serviceList[serviceOutput - 1];

            choosenAnimal.extraService = choosenService;
            Console.WriteLine($"Data saved: {choosenService.NameOfService} is now added to {choosenAnimal.Name} at the expense of {choosenService.PriceOfService}");
            Console.WriteLine("Press any key to return to main menu");
            Console.Read();
        }

    }
}
