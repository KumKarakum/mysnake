using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine (int initstart_y, int initend_y, int x, char sym)
        {
            plist = new List<Point>();
            for (int y = initstart_y; y < initend_y;  y++)
            {
                Point vp = new Point(x, y, sym);
                plist.Add(vp);
            }                 
        }        
    }
}