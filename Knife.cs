using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Salad
{
    class Knife
    {
        public void Cut(Papper p)
        {
            if (p.Havent_Cut)
            {
                p.Havent_Cut = false;
            }
        }

    }
}
