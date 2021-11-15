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
                new Animal { ID = 1, Name = "Maskot" },
                new Animal { ID = 2, Name = "Pelle" },
                new Animal { ID = 3, Name = "Stefan" },
            };

            foreach (var animal in animalList)
            {
                Console.WriteLine($"{animal.ID} - {animal.Name}");
            }
            Console.Read();
        }
    }
}
