using Code_Pattern___Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Model
{
    public class Application : IApplication
    {
        public PopulateMenu populateMenu;

        public Application(PopulateMenu populateMenu)
        {

            this.populateMenu = populateMenu;
        }

        public void Run()
        {
            populateMenu.Run();
            
        }

    }
}
