using Code_Pattern___Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Model
{
    public class Animal : IAnimal
    {
        public string Name { get; set; }

        public List<IAnimal> RegisterAnimal(List<IAnimal> animals)
        {
            //Register and save a new Animal to a list   
            {
                var animal = new Animal();

                Console.WriteLine("Enter the pets name");
                animal.Name = Console.ReadLine();
                animals.Add(animal);
            }
            Console.WriteLine("Animal saved - press any key");
            Console.Read();
            return animals;
        }

    }
}
