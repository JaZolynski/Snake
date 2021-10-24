using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Board
    {
        int weidth;
        int height;
        public Board(int w=50,int h=20)
        {
            weidth = w;
            height = h;
        }

        public void draw()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < weidth; j++)
                    if ((i == 0) || (i == height - 1) ||(j == 0) || (j==weidth-1))
                        Console.Write("#");
                    else
                        Console.Write(" ");
                Console.WriteLine();
            }
        }
    }
}
