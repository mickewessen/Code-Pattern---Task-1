using Code_Pattern___Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Model
{
    public class AnimalExtraServices : IAnimalExtraServices
    {
        public string NameOfService { get; set; }
        public decimal PriceOfService { get; set; }
    }
}
