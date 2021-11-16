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
            //List<string> typeofanimal = new() 
            //{ 
            //    "Cat",
            //    "Dog",
            //    "Elephant"
            //};
   
            {
                var animal = new Animal();
                Console.WriteLine("Enter the pets name");
                animal.Name = Console.ReadLine();
                Console.WriteLine("Choose which type of animal");
                //foreach (var item in typeofanimal)
                //{
                //    Console.WriteLine(item);
                //}

                animal.TypeOfAnimal = Console.ReadLine();
                animals.Add(animal);
            }
            Console.WriteLine("Animal saved - press any key");
            Console.Read();
            return animals;
        }
    }
}
