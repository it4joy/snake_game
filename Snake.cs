using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
    class Snake : Figure
    {
        Direction dir;

        public Snake(Point tail, int length, Direction _dir)
        {
            dir = _dir;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point( tail );
                p.Move( i, dir );
                pList.Add( p );
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove( tail );
            Point head = GetNextPoint();
            pList.Add( head );

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point( head );
            nextPoint.Move( 1, dir );
            return nextPoint;
        }

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for(int i = 0; i < pList.Count - 2; i++ )
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }

        public void ActiveKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                dir = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                dir = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                dir = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                dir = Direction.UP;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.symb = head.symb;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}
