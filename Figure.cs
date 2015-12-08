using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
    class Figure
    {
        List<Point> pList;

        public void DrawVertLine()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
