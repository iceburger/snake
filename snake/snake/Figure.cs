﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Figure
    {
        protected List<Point> pList;

        public void Drow()
        {
            foreach (Point i in pList)
            {
                i.Draw();
            }
        }
    }
}
