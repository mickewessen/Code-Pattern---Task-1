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
        public int ID { get; set; }
        public string Name { get; set; }

        public void RegisterAnimal()
        {
            Console.WriteLine("Enter the animals name");
            Console.ReadLine();
            Console.WriteLine("Animal saved - press any key");
            Console.Read();
        }
    }
}
