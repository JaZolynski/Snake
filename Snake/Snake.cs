using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
     public class Snake
    {
        public ConsoleKeyInfo lastdirection;
        int length;
        int alive;
        public Point head = new Point();
        public List<Point> body = new List<Point>();
        bool bad_button = false;
        public Snake()
        {
            alive = 1;
            length = 1;
            head.x = 2;
            head.y = 2;
            body.Add(head);
           
        }
        public bool IsAlive()
        {
            if (alive == 1)
                return true;
            else
                return false;
        }
        int a;
        public void Draw()
        {
            
            Console.SetCursorPosition(head.x, head.y);
            Console.Write("@");
            if(length<=body.Count)
            {
                Console.SetCursorPosition(body[0].x, body[0].y);
                Console.Write(" ");
                body.RemoveAt(0);

            }           
             Point point = new Point(head.x,head.y);
             body.Add(point);
            
           if(length>1)
            for (int i = 0; i < length-1; i++)
            {
                if ((body[i].x == head.x) && (body[i].y == head.y))
                {
                    alive = 0;
                }
            }

        }

        public void move(ConsoleKeyInfo direction)
        {
            

            switch (direction.Key)
            {
                case ConsoleKey.RightArrow:
                    head.x++;
                    break;
                case ConsoleKey.LeftArrow:
                    head.x--;
                    break;
                case ConsoleKey.UpArrow:
                    head.y--;
                    break;
                case ConsoleKey.DownArrow:
                    head.y++;
                    break;
                 default:
                    Console.Clear();
                    Console.WriteLine("You pressed wrong button,game over");
                    Thread.Sleep(1500);
                  

                    alive = 0;
                    break;

            }
            lastdirection = direction;
            if ((head.x == 0) || (head.x == 50) || (head.y == 0) || (head.y == 19))          
                alive = 0;                    
            Draw();                 
        }
        public void eat()
        {
            length++;
        }
        

    }
}
