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
            Point p1 = new Point(13, 7, '*');

            Point p2 = new Point(7, 3, '#');

            p1.Draw();
            p2.Draw();

            List<int> intList = new List<int>();

            intList.Add( 0 );
            intList.Add( 1 );
            intList.Add( 2 );

            int x = intList[0];
            int y = intList[1];
            int z = intList[2];

            foreach (int i in intList)
            {
                Console.WriteLine( i );
            }

            List<Point> pList = new List<Point>();

            pList.Add( p1 );
            pList.Add( p2 );

            Console.ReadLine();
        }

    }
}