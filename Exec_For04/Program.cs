﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 20; i++)

            {
                if (i % 3 == 0 && i != 15)
                {
                    Console.WriteLine("foo");
                }
                else if (i % 5 == 0 && i != 15)
                {
                    Console.WriteLine("bar");
                }
                else if (i % 15 == 0)
                {
                    Console.WriteLine("foobar");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
