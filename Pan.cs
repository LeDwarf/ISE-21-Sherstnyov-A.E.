using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Salad
{
    class Pan
    {
        private Tomato_Sauce[] sauce;
        private Water[] water;
        private Papper[] pappers;
        private Salt salt;
        public bool ReadyToGo { get { return Check(); } }

        public void Init(int CountPappers, int CountSauce)
        {
            water = new Water[3];
            pappers = new Papper[CountPappers];
            sauce = new Tomato_Sauce[CountSauce];
        }


        public void AddPappers(Papper e)
        {
            for (int i = 0; i < pappers.Length; i++)
            {
                if (pappers[i] == null)
                {
                    pappers[i] = e;
                    return;
                }
            }
        }

        public bool Check()
        {

            if (pappers.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < pappers.Length; ++i)
            {
                if (pappers[i] == null)
                {
                    return false;
                }
            }
            return true;
        }

        public void AddSalt(Salt s)
        {

            salt = s;

        }

        public void AddSauce(Tomato_Sauce m)
        {
            for (int i = 0; i < sauce.Length; i++)
            {
                if (sauce == null)
                {
                    sauce[i] = m;
                    return;
                }
            }
        }

        public void GetHeat()
        {
            if (!Check())
            {
                return;
            }
            if (pappers.Length > 0)
            {
                for (int i = 0; i < pappers.Length; i++)
                {
                    pappers[i].GetHeat();
                }
            }
        }


        public bool IsReady()
        {
            for (int i = 0; i < pappers.Length; i++)
            {
                if (pappers[i].Has_ready < 10)
                {
                    return false;
                }
            }
            return true;
        }

        public Papper[] GetSalad()
        {
            return pappers;
        }

    }
}
