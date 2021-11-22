﻿using Code_Pattern___Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Model
{
    public class Reciept : IReciept
    {
        public DateTime RecieptDate { get; set; }
        public decimal RecieptTotalPrice { get; set; }
        public IAnimal RecieptAnimal { get; set; }
        public ICustomer RecieptCustomer { get; set; }
        public IAnimalExtraServices RecieptExtraServices { get; set; }
    }
}
