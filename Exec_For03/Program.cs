using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                int countofempty = 5 - i;
                int countofstar = i;

                string row = new string(' ', countofempty) + new string('*', countofstar);
                Console.WriteLine(row);
            }
        }
    }
}
