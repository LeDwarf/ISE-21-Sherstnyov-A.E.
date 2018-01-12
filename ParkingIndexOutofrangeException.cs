using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    class ParkingIndexOutofrangeException : Exception
    {
        public ParkingIndexOutofrangeException() :
            base("В порту нет судна по такому месту") { }
    }
}
