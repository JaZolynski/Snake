using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;

            Board board = new Board();
            Snake snake = new Snake();
            Meal meal = new Meal();           
            Point a = new Point();          
            Console.CursorVisible=false;
            Console.Clear();
            board.draw();
            meal.Draw();
            cki = Console.ReadKey();
            while (snake.IsAlive())
            {
                
                Console.SetCursorPosition(1, 1);
                if (Console.KeyAvailable)
                    cki = Console.ReadKey();
                snake.move(cki);
                if((snake.head.x==meal.CurrentPosition.x)&&(snake.head.y==meal.CurrentPosition.y))
                {
                    snake.eat();
                    meal = new Meal();
                }
                Thread.Sleep(75);


            }
            Console.Clear();
            Console.WriteLine("You lost your game!");
            Console.WriteLine("Press any key to exit");
            

        }
    }
}
