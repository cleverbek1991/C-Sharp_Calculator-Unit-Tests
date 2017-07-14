using System;

namespace Calculator
{
    public class Calculator
    {
        public int sum;

        public int Add(int a, int b)
        {
            int sum = (a + b);
            return sum;
        }
        public int Subtract(int a, int b)
        {
            int dif = (a - b);
            return dif;
        }
        public int Multiply(int a, int b)
        {
            int mult = (a * b);
            return mult;
        }
        public int Divide(int a, int b)
        {
            int div = (a / b);
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
