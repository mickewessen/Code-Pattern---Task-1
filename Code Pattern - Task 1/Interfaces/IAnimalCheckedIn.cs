﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1.Interfaces
{
    public interface IAnimalCheckedIn
    {
        public DateTime CheckedInDate { get; set; }
        public IAnimal Animal { get; set; }
        public bool isCheckedIn { get; set; }
    }
}
