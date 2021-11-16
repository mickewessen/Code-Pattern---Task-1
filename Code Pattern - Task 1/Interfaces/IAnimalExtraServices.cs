using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Interfaces
{
    public interface IAnimalExtraServices
    {
        public IAnimal AnimalWithExtraServices { get; set; }
        public bool AnimalShower(IAnimal animal);
        public decimal ShowerPrice { get; set; }
    }
}
