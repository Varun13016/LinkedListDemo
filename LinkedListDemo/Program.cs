﻿using System;
using System.Collections.Generic;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> L1 = new List<int>();
            L1.Add(56);
            L1.Add(70);
            L1.Add(30);
            foreach (var element in L1)
            {
                Console.WriteLine(element);
            }
        }
    }
}
