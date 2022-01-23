using Code_Pattern___Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Model
{
    public class ReturnDataAnimals
    {
        public void ReturnAnimalData(List<IAnimal> animalList)
        {
            Console.Clear();
            if (animalList.Count == 0)
            {
                Console.WriteLine("There are no animals registered yet, press enter to go back to main menu");
                Console.Read();
            }
            else
            {
                foreach (var animal in animalList)
                {
                    Console.WriteLine($"Petname: {animal.Name} - Type of pet: {animal.TypeOfAnimal} - Status: {animal.IsCheckedIn}");
                }
                Console.WriteLine("Press any key to return to menu");
                Console.Read();
            }

        }

        public void ReturnAnimalDataCheckedInStatus(List<IAnimal> animalList)
        {
            Console.Clear();
            foreach (var animal in animalList.Where(x=>x.IsCheckedIn== "Checked in"))
            {
                Console.WriteLine($"Petname: {animal.Name} - Type of pet: {animal.TypeOfAnimal} - Status: {animal.IsCheckedIn}");
            }
            Console.WriteLine("Press any key to return to menu");
            Console.Read();
        }

    }
}
