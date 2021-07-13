using System;

namespace simultaneousEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given a Linear Equation of the form\n ax + by = e \n cx + dy = f \n solving for unknown values X and Y");
            Console.WriteLine("Enter your values for a, b, e, c, d, f");
            Console.Write("a : ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b : ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.Write("e : ");
            double e = Convert.ToInt32(Console.ReadLine());
            Console.Write("c : ");
            double c = Convert.ToInt32(Console.ReadLine());
            Console.Write("d : ");
            double d = Convert.ToInt32(Console.ReadLine());
            Console.Write("f : ");
            double f = Convert.ToInt32(Console.ReadLine());

            double x = (e * d - b * f)/ (a * d - b * c);
            double y = (a * f - e * c)/ (a * d - b * c);

            if (a * d - b * c == 0) {
                Console.WriteLine("This Equation has no Solution");
            }
            else {
                Console.WriteLine($"X = {x}, Y = {y}");
            }
            
        }
    }
}
