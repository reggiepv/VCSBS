#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
        private int x, y;

        private static int objectCount = 0;

        public int ObjectCountOld()
        {
            return objectCount;
        }
        public static int ObjectCount() => objectCount;

        public Point()
        {
            objectCount++;
            x = 0;
            y = 0;
            Console.WriteLine("Default constructor is called");
        }

        public Point(int x, int y)
        {
            objectCount++;
            this.x = x;
            this.y = y;
            Console.WriteLine($"x:{x}, y:{y}");
        }
   
        public double DistanceToPoint(Point other)
        {
            int xDiff = x - other.x;
            int yDiff = y - other.y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }

    }
}
