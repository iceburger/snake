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
            /*int x1 = 12;
            int y1 = 14;
            char sym1 = '*';*/

            /*Draw( x1, y1, sym1 );*/

            Point p1 = new Point();

            p1.x = 13;
            p1.y = 7;
            p1.sym = '*';

            Point p2 = new Point();

            p2.x = 7;
            p2.y = 3;
            p2.sym = '*';

            p1.Draw();
            p2.Draw();

            Console.ReadLine();
        }

    }
}
