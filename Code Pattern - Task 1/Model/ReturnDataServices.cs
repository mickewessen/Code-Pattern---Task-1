using Code_Pattern___Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Model
{
    public class ReturnDataServices
    {
        public void ReturnAnimalServiceData(List<IAnimalExtraServices> serviceList)
        {
            Console.Clear();
            foreach (var service in serviceList)
            {
                Console.WriteLine($"Service: {service.NameOfService} - Price: {service.PriceOfService}");
            }
            Console.WriteLine("Press any key to return to menu");
            Console.Read();
        }

    }
}
