using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
           int num;
           do
           {
               num = int.Parse(Console.ReadLine());
           } while (num != 0);
        }
    }
}
