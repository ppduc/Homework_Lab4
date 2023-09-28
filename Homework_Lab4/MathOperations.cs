using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lab4
{
    public delegate void MyDeleagate(double a, double b);
    internal class MathOperations
    {
        public void Add(double a, double b)
        {
            Console.WriteLine("Add Result: {0}", a + b);
        }
        public void Subtract(double a, double b)
        {
            Console.WriteLine("Subtract Result: {0}", a - b);
        }
        public void Multi(double a, double b)
        {
            Console.WriteLine("Multi Result: {0}", a * b);
        }
        public void Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("B must be different zero");
            }
            else
            {
                Console.WriteLine("Divide result:", a / b);
            }
        }

    }
}
