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
            RAM obj = new RAM(10, 14);
            obj.construct();

            Point p1 = new Point(10, 15, 'L');
            p1.x = 1;
            p1.x = 50;
            p1.y = 20;
            p1.symb = '/';
            p1.Draw();

            Console.ReadLine();
        }
    }
}