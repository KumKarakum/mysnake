﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> plist;

        public HorizontalLine (int xLeft, int xRight, int y, char sym)
        {
            plist = new List<Point>();
            for (int x = xLeft; x < xRight; x++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);


            }

        }

        public void Draw ()
        {
           foreach (Point p in plist)
            {
                p.Draw();

            }


        }


    }
}
