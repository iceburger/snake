using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            hLine upLine = new hLine( 0, 78, 0, '#' );
            hLine downLine = new hLine(0, 78, 24, '#');
            vLine leftLine = new vLine(0, 24, 0, '#');
            vLine rightLine = new vLine(0, 24, 78, '#');

            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point( 4, 5, '*' );

            Snake snake = new Snake( p, 4, Direction.RIGHT );

            while (true)
            {
                if (Console.KeyAvailable) {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey( key.Key );
                }
                snake.Move();
                Thread.Sleep(200);
            }

            Console.ReadLine();
        }

    }
}