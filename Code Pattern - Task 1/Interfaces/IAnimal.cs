﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Interfaces
{
    public interface IAnimal
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void RegisterAnimal()
        {

        }
    }
}