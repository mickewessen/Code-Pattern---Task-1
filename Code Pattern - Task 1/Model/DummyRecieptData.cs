using Code_Pattern___Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Model
{
    public class DummyRecieptData
    {
        public void ReturnRecieptData()
        {
            List<IReciept> recieptList = new List<IReciept>
            {
                new Reciept {RecieptDate = DateTime.Now, Customer="Micke", Animal="Maskot", Price=10 },
                new Reciept {RecieptDate = DateTime.Now, Customer="Samuel", Animal="Pelle", Price=20 },
                new Reciept {RecieptDate = DateTime.Now, Customer="Daniel", Animal="Stefan", Price=30 }
            };

            foreach (var item in recieptList)
            {
                Console.WriteLine($"Datum:{item.RecieptDate} - Kund: {item.Customer} - Djur: {item.Animal} - Pris: {item.Price}kr");
            }
            Console.Read();
        }
    }
}
