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

            List<int> NumList = new List<int>();
            NumList.Add (5);
            NumList.Add (6);
            NumList.Add (7);

            int x = NumList[0];
            int y = NumList[1];
            int z = NumList[2];

            foreach (int i in NumList)
            {
                Console.WriteLine(i);
            }

            NumList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
      
            Console.ReadLine();
        }
                
    }
}
