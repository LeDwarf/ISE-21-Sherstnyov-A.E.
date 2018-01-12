using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Salad
{
    class WaterTap
    {
        public bool State { set; get; }
        public void Wash(Papper p)
        {
            if (State)
            {
                p.Dirty = 0;
            }
        }

        public Water GetWater()
        {
            if (State)
            {
                return new Water();
            }
            else
            {
                return null;
            }
        }

    }
}
