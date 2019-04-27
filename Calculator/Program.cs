using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public void Add(double x,double y)
        {
            double c = 0;
            c = x + y;
            Console.WriteLine(c);
        }
        public void Substract(double x, double y)
        {
            double c = 0;
            c = x - y;
            Console.WriteLine(c);
        }
        public void Divide(double x, double y)
        {
            double c = 0;
            c = x / y;
            Console.WriteLine(c);
        }
        public void Multiply(double x, double y)
        {
            double c = 0;
            c = x * y;
            Console.WriteLine(c);
        }
        public void pow(double x, double y)
        {
            double c = 0;
            c = Math.Pow(x,y);
            Console.WriteLine(c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            string func = Console.ReadLine();
            double y = double.Parse(Console.ReadLine());
           
            Calculator calc = new Calculator();
            switch (func)
            {
                case "+":
                    calc.Add(x, y);
                    break;
                case "-":
                    calc.Substract(x, y);
                    break;
                case "*":
                    calc.Multiply(x, y);
                    break;
                case "/":
                    calc.Divide(x, y);
                    break;
                case "^":
                    calc.pow(x, y);
                    break;
                default:
                    break;
            }
        }
    }
}
