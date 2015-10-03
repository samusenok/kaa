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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorisontalLine Line = new HorisontalLine(5, 10, 8, '+');
            {
                Line.Drow();
            }

            VerticalLine vLine = new VerticalLine(15, 8, 20, '+');
            {
                vLine.Drow();
            }


            Console.ReadLine();
        }
                
    }
}
