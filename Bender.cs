using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Salad
{
    class Bender
    {
        public void Mix(Papper e)
        {
            if (e.Have_salt == false && e.Havent_Cut == false)
            {
                e.Mixed = true;
            }
            else
            if (e.Have_salt)
            {
                e.Mixed_with_salt = true;
            }
        }

    }
}
