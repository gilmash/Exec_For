using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Factorial
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            int num = 1;
            for(int i = 10; i >=1; i--)
            {
                num = num * i;
                
            }
            Console.WriteLine("10!="+num);
        }
    }
}
