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
        
        public void RegisterAnimal()
        {
            List<IAnimal> animalList = new List<IAnimal>();
            {
                var animal = new Animal();
                Console.WriteLine("Enter your first name");
                animal.Name = Console.ReadLine();
                animalList.Add(animal);
                Console.WriteLine("Animal saved - press any key");
                Console.Read();
            }

            //Console.WriteLine("Enter the animals name");
            //Console.ReadLine();
            //Console.WriteLine("Animal saved - press any key");
            //Console.Read();
        }

    }
}
