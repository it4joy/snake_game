using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize( 80, 25 );

            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(10, 20, 'C');
            p3.Draw();

            // frame rendering;
            HorizontalLine topLine = new HorizontalLine( 0, 78, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine( 0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine( 0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine( 0, 24, 78, '+');
            topLine.DrawMain();
            bottomLine.DrawMain();
            leftLine.DrawMain();
            rightLine.DrawMain();

            Console.ReadLine();
        }
    }
}
