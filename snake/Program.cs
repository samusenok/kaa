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
            Console.SetBufferSize(80, 25);

            //отрисовка рамочки
            HorisontalLine UpLine = new HorisontalLine(0, 78, 0, '*');
            HorisontalLine DownLine = new HorisontalLine(0, 78, 24, '*');
            VerticalLine LeftLine = new VerticalLine(0, 0, 24, '*');
            VerticalLine RightLine = new VerticalLine(78, 0, 24, '*');
            UpLine.Drow();
            DownLine.Drow();
            LeftLine.Drow();
            RightLine.Drow();
            
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

     
     


            Console.ReadLine();
        }
                
    }
}
