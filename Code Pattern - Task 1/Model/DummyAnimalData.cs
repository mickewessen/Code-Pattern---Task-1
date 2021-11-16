using Code_Pattern___Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Model
{
    public class DummyAnimalData
    {
        public void ReturnAnimalData()
        {
            List<IAnimal> animalList = new List<IAnimal>()
            {
                new Animal { Name = "Maskot" },
                new Animal { Name = "Pelle" },
                new Animal { Name = "Stefan" },
            };

            foreach (var animal in animalList)
            {
                Console.WriteLine($"{animal.Name}");
            }
            Console.Read();
        }
    }
}
