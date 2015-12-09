using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; // my adding;
using System.Threading.Tasks;

namespace snake_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize( 80, 25 );

            // frame rendering;
            HorizontalLine topLine = new HorizontalLine( 0, 78, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine( 0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine( 0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine( 0, 24, 78, '+');
            topLine.DrawMain();
            bottomLine.DrawMain();
            leftLine.DrawMain();
            rightLine.DrawMain();

            // point rendering;
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake( p, 4, Direction.RIGHT );
            snake.DrawMain();

            // keyboard control;
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(); // get the touch of a button;
                    snake.ActiveKey(key.Key);
                }
                Thread.Sleep( 300 );
                snake.Move();
            }

            // Console.ReadLine();
        }
    }
}
