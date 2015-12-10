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
            Walls walls = new Walls( 80, 25 );
            walls.DrawMain();

            // point rendering;
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.DrawMain();

            // food;
            FoodCreator foodCreator = new FoodCreator( 80, 25, '$' );
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    // Console.BackgroundColor = ConsoleColor.DarkRed;
                    // Thread.Sleep( 300 );
                    break;
                }
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
