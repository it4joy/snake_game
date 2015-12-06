﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
    class Point
    {
        public int x;
        public int y;
        public char symb;

        public Point() // constructor;
        {
        }

        public Point(int _x, int _y, char _symb)
        {
            x = _x;
            y = _y;
            symb = _symb;
        }

        public void Draw() // 'void' - it's means, that this function returns nothing;
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
    }
}
