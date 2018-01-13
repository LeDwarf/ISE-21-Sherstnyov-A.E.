using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    public class Boat : Ship
    {
        public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }
            protected set
            {
                if(value >0 && value < 300)
                {
                    base.MaxSpeed = value;
                }
                else
                {
                    base.MaxSpeed = 150;
                }
            }
        }

        public override int MaxCountPassengers
        {
            get
            {
                return base.MaxCountPassengers;
            }
            protected set
            {
                if (value > 0 && value < 3)
                {
                    base.MaxCountPassengers = value;
                }
                else
                {
                    base.MaxCountPassengers = 2;
                }
            }
        }

        public override double Weight
        {
            get
            {
                return base.Weight;
            }
            protected set
            {
                if (value > 500 && value < 1500)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 1000;
                }
            }
        }

        public Boat(int maxSpeed, int maxCountPassenger, double weight, Color color)
        {
            this.MaxSpeed = MaxSpeed;
            this.MaxCountPassengers = maxCountPassenger;
            this.ColorBody = color;
            this.countPassengers = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }

        public override void moveCat(Graphics g)
        {
			startPosX += MaxSpeed;

            drawCat(g);
        }

        public override void drawCat(Graphics g)
        {
            drawSportCat(g);
        }

        protected virtual void drawSportCat(Graphics g)
        {
            Pen pen = new Pen(Color.Black);


            Brush br = new SolidBrush(ColorBody);
            g.FillEllipse(br, startPosX+1, startPosY+1, 20, 20);
            g.FillEllipse(br, startPosX+1, startPosY+1 + 30, 20, 20);
            g.FillEllipse(br, startPosX+1 + 70, startPosY+1, 20, 20);
            g.FillEllipse(br, startPosX+1 + 70, startPosY+1 + 30, 20, 20);

            g.FillRectangle(br, startPosX+10, startPosY, 72, 20);
            g.FillRectangle(br, startPosX+10, startPosY, 72, 53);

            Brush brBrown = new SolidBrush(Color.Brown);
            g.FillRectangle(brBrown, startPosX + 15, startPosY + 15, 60, 25);
        }
    }
}
