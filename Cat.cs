using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    class Cat : Boat
    {
        private bool leftBob;
        private bool rightBob;
        private Color dopColor;

        public Cat(int maxSpeed, int maxCountPassenget, double weight, Color color, 
            bool leftBob, bool rightBob, Color dopColor) :
            base(maxSpeed, maxCountPassenget, weight, color)
        {
            this.leftBob = leftBob;
            this.rightBob = rightBob;
            this.dopColor = dopColor;
        }

        protected override void drawSportCat(Graphics g)
        {
            if (leftBob)
            {
                Brush br = new SolidBrush(dopColor);
                g.FillEllipse(br, startPosX + 1, startPosY-5 + 1, 25, 25);
				g.FillEllipse(br, startPosX + 1 + 70, startPosY-5 + 1, 25, 25);				
                g.FillRectangle(br, startPosX + 10, startPosY-5, 72, 28);
            }
            if (rightBob)
            {
                Brush br = new SolidBrush(dopColor);
				g.FillEllipse(br, startPosX + 1, startPosY+5 + 30, 25, 25);
				g.FillEllipse(br, startPosX + 1 + 70, startPosY+5 + 30, 25, 25);
				g.FillRectangle(br, startPosX + 10, startPosY+3 +30, 72, 28);
			}
			base.drawSportCat(g);
        }

        public void setDopColor(Color color)
        {
            dopColor = color;
        }
    }
}
