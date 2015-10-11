using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            hLine hline = new hLine(7, 12, 9, '*');

            hline.Drow();

            vLine vline = new vLine(3, 7, 4, '#');

            vline.Drow();

            Point p = new Point( 11, 5, '*' );

            Snake mySnake = new Snake( p, 4, Direction.LEFT );

            Console.ReadLine();
        }

    }
}