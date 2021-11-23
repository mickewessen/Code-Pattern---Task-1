using Code_Pattern___Task_1.Model;
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
        public decimal RecieptTotalPrice { get; set; }
        public ICustomer RecieptCustomer { get; set; }


    }
}
