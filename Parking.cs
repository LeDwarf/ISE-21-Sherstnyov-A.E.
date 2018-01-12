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
		ClassArray<ITransport> parking;

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
		}
	}
}
