using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(79, 25);
            Console.SetBufferSize(79, 25);

            HorizontalLine hline_up = new HorizontalLine(0, 78, 0, '+');
            hline_up.Draw();
            HorizontalLine hline_down = new HorizontalLine(0, 78, 24, '+');
            hline_down.Draw();

            VerticalLine vline_left = new VerticalLine (0, 24, 0, '+');
            vline_left.Draw();
            VerticalLine vline_right = new VerticalLine(0, 24, 78, '+');
            vline_right.Draw();


            Point p = new Point(4, 5, '*');
            p.Draw();

            Snake snake = new Snake(p, 10, Direction.RIGHT);



            Console.ReadLine();
        }

    }
}
