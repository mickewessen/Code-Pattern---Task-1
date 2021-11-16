using Code_Pattern___Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Model
{
    public class Menu : IMenu
    {
        public void MenuItems()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Register new customer");
            Console.WriteLine("2) Register new animal");
            Console.WriteLine("3) Show all customers");
            Console.WriteLine("4) Show all animals");
            Console.WriteLine("5) Check IN animals");
            Console.WriteLine("6) Check OUT animals");
            Console.WriteLine("7) List of animals checked in");
            Console.WriteLine("8) Services");
            Console.WriteLine("9) Receipt");
            Console.WriteLine("10) Exit");
            Console.Write("\r\nSelect an option: ");
        }
    }
}
