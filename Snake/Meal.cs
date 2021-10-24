using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Meal
    {
        public Point CurrentPosition = new Point();
        public int x;
        public int y;
        
        public Meal()
        {
           Random random = new Random();
           x = random.Next(2, 44);
           y = random.Next(2, 8);
           CurrentPosition = new Point(x, y);
           Draw();
        }
       

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("$");

        }


    }
}
