﻿using System;

namespace DemoEstruturaCodicional
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) { Console.WriteLine("Par"); } else { Console.WriteLine("Impar"); }
        }
    }
} 