﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsOfObjects
{
    internal class Program
    {
        public static void FillArrPoints(Point[] points)
        {
            Random random = new Random();

            for (int i = 0; i < points.Length; i++)
            {
                int randomX = random.Next(-10, 11);
                int randomY = random.Next(-10, 11);

                points[i] = new Point(randomX, randomY);
            }
        }

        public static void PrintArrPoints(Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                Console.Write($"value of x {points[i].GetX()} ");
                Console.WriteLine($"value of y {points[i].GetY()} ");
            }
        }
        static void Main(string[] args)
        {
            Point[] arrPoints = new Point[10];
            FillArrPoints(arrPoints);
            PrintArrPoints(arrPoints);
         


        }
    }
}
