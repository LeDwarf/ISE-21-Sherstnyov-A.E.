using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Salad
{
    class Water
    {
        private int temperature = 0;
        public int Temperature { get { return temperature; } }
        public void GetHeat()
        {
            if (temperature < 100)
            {
                temperature++;
            }
        }

    }
}
