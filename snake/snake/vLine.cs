using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class vLine : Figure
    {

        public vLine(int yTop, int yBottom, int x, char sym)
        {
            pList = new List<Point>();

            for (int i = yTop; i <= yBottom; i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);
            }

        }


    }

}