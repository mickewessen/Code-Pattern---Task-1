using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Interfaces
{
    public interface IReciept
    {
        public DateTime RecieptDate { get; set; }
        public decimal Price { get; set; }
        public string Animal { get; set; }
        public string Customer { get; set; }
        //public ICustomer PayingCustomer { get; set; }
        //public IAnimal PayingCustomersAnimal { get; set; }
        //public IAnimalExtraServices Extras { get; set; }

        public void RecieptTotal()
        {

        }

    }
}
