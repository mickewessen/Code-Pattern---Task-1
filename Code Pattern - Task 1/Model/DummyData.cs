using Code_Pattern___Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Model
{
    public class DummyData
    {
        public List<ICustomer> PopulateDummyDataCustomer(List<ICustomer> customerList)
        {
            customerList.Add(new Customer { FirstName = "Micke", LastName = "Wessén", PhoneNumber = 0738142090 });
            return customerList;
        }

        public List<IAnimal> PopulateDummyDataAnimal(List<IAnimal> animalList)
        {
            animalList.Add(new Animal { Name = "Maskot", TypeOfAnimal="Dog", IsCheckedIn="Not Checked in" });
            animalList.Add(new Animal { Name = "Pelle", TypeOfAnimal = "Cat", IsCheckedIn = "Checked in" });
            return animalList;
        }

        public List<IAnimalExtraServices> PopulateDummyDataServices(List<IAnimalExtraServices> serviceList)
        {
            serviceList.Add(new AnimalExtraServices { NameOfService = "Bathing", PriceOfService = 10 });
            serviceList.Add(new AnimalExtraServices { NameOfService = "Claw cutting", PriceOfService = 5 });
            return serviceList;  
        }
    }
}
