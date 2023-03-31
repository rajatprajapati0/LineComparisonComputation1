using System;

namespace LineComarisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.WriteLine("\nEnter values for (x1,y1)(x2,y2) co-ordinates to get length of line");
            Console.WriteLine("\nEnter 'x1'");
            double x1=double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter 'y1'");
            double y1=double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter 'x2'");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter 'y2'");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine(Program.LenghtOfLine(x1, y1, x2, y2)); 

            Console.ReadLine();
        }
        static string LenghtOfLine(double x1, double y1, double x2, double y2)
        {
            double lenthOfLine = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));

            return $"lenth of line :{lenthOfLine}";
        }
    }
}
 