﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    class ParkingAlreadyHaveException : Exception
    {
        public ParkingAlreadyHaveException() :
            base("В порту уже есть такое судно") { }
    }
}
