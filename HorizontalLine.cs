﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int xLeft, int xRight, int y, char symb)
        {
            pList = new List<Point>(); // list of Points;

            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point( x, y, symb );
                pList.Add( p );
            }
        }

        public void DrawLine()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
