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
            Console.WriteLine("1 - Register new customer");
            Console.WriteLine("2 - Register new animal");
            Console.WriteLine("3 - Show all customers");
            Console.WriteLine("4 - Show all animals");
            Console.WriteLine("5 - Connect animal to customer");
            Console.WriteLine("6 - Check IN animals");
            Console.WriteLine("7 - Check OUT animals");
            Console.WriteLine("8 - List of all checked in animals");
            Console.WriteLine("9 - Services");
            Console.WriteLine("10 - Receipt");
            Console.WriteLine("11 - Exit");
            Console.Write("\r\nSelect an option: ");
        }
    }
}
