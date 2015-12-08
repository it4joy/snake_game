using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int yTop, int yBottom, int x, char symb)
        {
            pList = new List<Point>();

            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point( x, y, symb );
                pList.Add( p );
            }
        }

        public void DrawVertLine()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
