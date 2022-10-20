using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for(int i = 1 ; i <= 5; i++)
            {
                int plus = 5 - i;
                int number = i;

                string row = new string('+', plus);
            string row1 = new string(i.ToString()[0], number);
                Console.WriteLine(row+row1);
            }
            
         
          
        }
    }
}
