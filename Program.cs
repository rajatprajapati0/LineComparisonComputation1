using System;namespace LineComarisonProblem{    internal class Program    {        static void Main(string[] args)        {            Console.WriteLine("Welcome to Line Comparison Computation Program");
            double firstLine=0;            double secondLine=0;            for (int i = 0; i < 2; i++)             {                switch (i)                {                    case 0:
                        Console.WriteLine("enter value for first line");                         firstLine=Program.LenghtOfLine();                        break;                    case 1:                        Console.WriteLine("enter value for second line");                         secondLine =Program.LenghtOfLine();                        break;                }             
            }
            Console.WriteLine($"length of first  :{firstLine}");
            Console.WriteLine($"length of second :{secondLine}");            bool check=  firstLine.Equals(secondLine); 
            if (check == true) 
            {
                Console.WriteLine("lines are equal");
            }
            else
            {
                Console.WriteLine("lines are not equal");
            }
            Console.Read();        }        static double LenghtOfLine()        {
            Console.WriteLine("\nEnter values for (x1,y1)(x2,y2) co-ordinates to get length of line");            Console.WriteLine("\nEnter 'x1'");            double x1 = double.Parse(Console.ReadLine());            Console.WriteLine("\nEnter 'y1'");            double y1 = double.Parse(Console.ReadLine());            Console.WriteLine("\nEnter 'x2'");            double x2 = double.Parse(Console.ReadLine());            Console.WriteLine("\nEnter 'y2'");            double y2 = double.Parse(Console.ReadLine());            double lenthOfLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));            return lenthOfLine;        }    }}
