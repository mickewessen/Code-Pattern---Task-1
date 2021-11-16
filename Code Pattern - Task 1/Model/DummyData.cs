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
            animalList.Add(new Animal { Name = "Maskot", TypeOfAnimal="Dog" });
            return animalList;
        }

        public List<IReciept> PopulateDummyDataReciept(List<IReciept> recieptList)
        {
            recieptList.Add(new Reciept { RecieptDate = DateTime.Now, Customer = "Micke", Animal = "Mascot", Price = 10 });
            return recieptList;
        }
    }
}
