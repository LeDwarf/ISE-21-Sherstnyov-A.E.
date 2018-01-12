using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    class Parking
    {
        /*ClassArray<ITransport> parking;

		int countPlaces = 10;
		int placesSizeWidth = 200;
		int placeSizeHeight = 80;

		public Parking()
		{
			parking = new ClassArray<ITransport>(countPlaces, null);
		}

		public int PutCatInParking(ITransport cat)
		{
			return parking + cat;
		}

		public ITransport GetCatInParking(int ticket)
		{
			return parking - ticket;
		}

		public void Draw(Graphics g, int width, int height)
		{
			DrawMarking(g);
			for (int i=0; i< countPlaces; i++)
			{
				var cat = parking.getObject(i);
				if(cat != null)
				{
					cat.setPosition(10 +(200 * (i/5)),10+(80*(i%5)));
					cat.drawCat(g);
				}
			}
		}

		private void DrawMarking(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 3);
			g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placesSizeWidth, 480);
			for (int i=0; i<countPlaces/5; i++)
			{
				for (int j=0; j<6; ++j)
				{
					g.DrawLine(pen, i * placesSizeWidth, j * placeSizeHeight, 
						i * placesSizeWidth + 110, j * placeSizeHeight);
				}
				g.DrawLine(pen,i*placesSizeWidth,0,i*placesSizeWidth,400);
			}
		}*/

        //для list'а

        List<ClassArray<ITransport>> parkingStages;
        int countPlaces = 20;
        int placeSizeWidth = 210;
        int placeSizeHeight = 80;
        int currentLevel;

        public int getCurrentLevel { get { return currentLevel; } }

        public Parking(int coutStages)
        {
            parkingStages = new List<ClassArray<ITransport>>();
            for (int i = 0; i < coutStages; i++)
            {
                parkingStages.Add(new ClassArray<ITransport>(countPlaces, null));
            }
        }

        public void LevelUp()
        {
            if (currentLevel + 1 < parkingStages.Count)
            {
                currentLevel++;
            }
        }

        public void LevelDown()
        {
            if (currentLevel > 0)
            {
                currentLevel--;
            }
        }

        public int PutCatInParking(ITransport cat)
        {
            return parkingStages[currentLevel] + cat;
        }

        public ITransport GetCatInParking(int ticket)
        {
            return parkingStages[currentLevel] - ticket;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < countPlaces; i++)
            {
                var cat = parkingStages[currentLevel][i];
                if (cat != null)
                {
                    cat.setPosition(10 + (210 * (i / 5)), 10 + (80 * (i % 5)));
                    cat.drawCat(g);
                }
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawString("L" + (currentLevel + 1), new Font("Arial", 30), new SolidBrush(Color.Blue),
                (countPlaces / 5) * placeSizeWidth - 50, 420);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 480);
            for (int i = 0; i < countPlaces / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight,
                        i * placeSizeWidth + 110, j * placeSizeHeight);
                    if (j < 5)
                    {
                        g.DrawString((i * 5 + j + 1).ToString(), new Font("Arial", 30),
                            new SolidBrush(Color.Blue), i * placeSizeWidth + 30, j * placeSizeHeight + 20);
                    }
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 400);
            }
        }
    }
}


