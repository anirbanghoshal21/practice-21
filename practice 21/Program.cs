using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int bigNum;
            Console.WriteLine("Number 1: " + num1);
            Console.WriteLine("Number 2: " + num2);
            if (num1 > num2)
            {
                bigNum = num1;
            }
            else
            {
                bigNum = num2;
            }
            Console.WriteLine("Biggest number is: " + bigNum);
            Console.ReadKey();
        }
    }
}
