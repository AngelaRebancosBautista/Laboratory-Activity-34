using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());

            while (number >= 10) 
            {
                    int sum = 0;
                while (number > 0) 
                {
                    sum += number % 10; 
                    number /= 10; 
                }
                   number = sum; 
            }
             Console.WriteLine("Single-digit result: " + number);
        }
    }
}


