﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {

       protected List<Point> plist;


        public void Draw()
        {
            foreach (Point vp in plist) vp.Draw();
        }


    }
}
