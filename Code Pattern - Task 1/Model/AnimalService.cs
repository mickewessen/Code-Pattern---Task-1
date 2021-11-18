﻿using Code_Pattern___Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Model
{
    public class AnimalService
    {
        public ReturnData data;

        public AnimalService(ReturnData data)
        {
            this.data = data;
        }

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
                Console.WriteLine("Enter the pets name");
                animal.Name = Console.ReadLine();
                Console.WriteLine("Choose which type of animal");
                foreach (var item in typeofanimal)
                {
                    Console.WriteLine(item);
                }
                
                //Take userinput and convert to int -1 for animal type
                var userInputTypeOfAnimal = Console.ReadLine();
                Int32.TryParse(userInputTypeOfAnimal, out int inputAsInt);
                var chosenAnimal = typeofanimal[inputAsInt-1];
                animal.TypeOfAnimal = chosenAnimal;

                //Take userinput and convert to int -1 for checked in status 
                Console.WriteLine("Do you want to check in the animal?");
                foreach (var checkedItem in checkedInStatus)
                {
                    Console.WriteLine(checkedItem);
                }
                var userInputCheckedInStatus = Console.ReadLine();
                Int32.TryParse(userInputCheckedInStatus, out int inputStatusAsInt);
                var statusAnimal = checkedInStatus[inputStatusAsInt -1];
                animal.IsCheckedIn = statusAnimal;

                animals.Add(animal);
            }
            Console.WriteLine("Animal saved - press any key");
            Console.Read();
            return animals;
        }

        public void CheckOutAnimal(List<IAnimal> animalList)
        {
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
            foreach (var notCheckedInAnimals in animalList.Where(x=>x.IsCheckedIn==("Not Checked in")))
            {
                Console.WriteLine($"{notCheckedInAnimals.Name}, {notCheckedInAnimals.TypeOfAnimal}, {notCheckedInAnimals.IsCheckedIn}");
            }
            Console.Read();
        }
    }
}
