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

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symb = p.symb;
        }

        public void Move(int offset, Direction dir)
        {
            if(dir == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if(dir == Direction.LEFT)
            {
                x = x - offset;
            }
            else if(dir == Direction.UP)
            {
                y = y + offset;
            }
            else if(dir == Direction.DOWN)
            {
                y = y - offset;
            }
        }

        public void Draw() // 'void' - it's means, that this function returns nothing;
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }

        public void Clear()
        {
            symb = ' ';
            Draw();
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + symb;
        }
    }
}
