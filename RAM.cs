using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
    class RAM
    {
        public int x;
        public int y;
        public int result;

        public RAM()
        { 
        }

        public RAM(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public void construct()
        {
            result = x + y;
            Console.WriteLine("Result is: " + result);
        }
    }
}
