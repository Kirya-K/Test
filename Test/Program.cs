﻿using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Введите А:");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите B:");
            int b = Int32.Parse(Console.ReadLine());

            int c = a + b;
            Console.WriteLine("=" + c);

            int d = a - b;
            Console.WriteLine("=" + d);

            int e = a * b;
            Console.WriteLine("=" + e);

        }
    }
}
