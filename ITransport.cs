using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2_1
{
    public interface ITransport
    {
        void moveCat(Graphics g);
        void drawCat(Graphics g);
        void setPosition(int x, int y);
        void loadPassenger(int count);
        int getPassenger();
        void setMainColor(Color color);
    }
}
