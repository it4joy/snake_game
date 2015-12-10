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
            VerticalLine v1 = new VerticalLine( 0, 10, 5, '%' );
            v1.DrawMain();

            // point rendering;
            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            fSnake.DrawMain();
            Snake snake = (Snake) fSnake;

            HorizontalLine h1 = new HorizontalLine( 0, 5, 6, '&' );

            List<Figure> figures = new List<Figure>();
            figures.Add( fSnake );
            figures.Add( v1 );
            figures.Add( h1 );

            foreach (var f in figures)
            {
                f.DrawMain();
            }

            // food;
            FoodCreator foodCreator = new FoodCreator( 80, 25, '$' );
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep( 300 );

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(); // get the touch of a button;
                    snake.ActiveKey(key.Key);
                }
            }
        }
    }
}
