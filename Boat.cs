using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    public class Boat : Ship, IComparable<Boat>, IEquatable<Boat>
    {
        public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }
            protected set
            {
                if (value > 0 && value < 300)
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

        public Boat(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 4)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                MaxCountPassengers = Convert.ToInt32(strs[1]);
                Weight = Convert.ToInt32(strs[2]);
                ColorBody = Color.FromName(strs[3]);
            }
        }

        public override void moveCat(Graphics g)
        {
			startPosX += MaxSpeed;
				/*(MaxSpeed * 50 / (float)Weight) /
					(countPassengers == 0 ? 1 : countPassengers);*/
            drawCat(g);
        }

        public override void drawCat(Graphics g)
        {
            drawSportCat(g);
        }

        protected virtual void drawSportCat(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
           /* g.DrawEllipse(pen, startPosX, startPosY, 20, 20);
            g.DrawEllipse(pen, startPosX, startPosY +30, 20, 20);
            g.DrawEllipse(pen, startPosX +70, startPosY, 20, 20);
            g.DrawEllipse(pen, startPosX +70, startPosY +30, 20, 20);
            g.DrawRectangle(pen, startPosX-1, startPosY + 10, 93, 30); */

            Brush br = new SolidBrush(ColorBody);
            g.FillEllipse(br, startPosX+1, startPosY+1, 20, 20);
            g.FillEllipse(br, startPosX+1, startPosY+1 + 30, 20, 20);
            g.FillEllipse(br, startPosX+1 + 70, startPosY+1, 20, 20);
            g.FillEllipse(br, startPosX+1 + 70, startPosY+1 + 30, 20, 20);
            //g.FillRectangle(br, startPosX, startPosY + 10, 92, 30);
            g.FillRectangle(br, startPosX+10, startPosY, 72, 20);
            g.FillRectangle(br, startPosX+10, startPosY, 72, 53);

            Brush brBrown = new SolidBrush(Color.Brown);
            g.FillRectangle(brBrown, startPosX + 15, startPosY + 15, 60, 25);
        }

        public override string getInfo()
        {
            return MaxSpeed + ";" + MaxCountPassengers + ";" +
                Weight + ";" + ColorBody.Name;
        }

        public int CompareTo(Boat other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (MaxCountPassengers != other.MaxCountPassengers)
            {
                return MaxCountPassengers.CompareTo(other.MaxCountPassengers);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (ColorBody != other.ColorBody)
            {
                return ColorBody.Name.CompareTo(other.ColorBody.Name);
            }
            return 0;
        }
        public bool Equals(Boat other)
        {
            if (other == null)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (MaxCountPassengers != other.MaxCountPassengers)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (ColorBody != other.ColorBody)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Boat boatObj = obj as Boat;
            if (boatObj == null)
            {
                return false;
            }
            else
            {
                return Equals(boatObj);
            }
        }
        public override int GetHashCode()
        {
            return MaxSpeed.GetHashCode();
        }
    }
}
