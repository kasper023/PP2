﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for( int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("[*]");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}