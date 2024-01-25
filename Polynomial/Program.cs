using System.Xml.Schema;
using static System.Console;
namespace Polynomial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degree;
            double a, b, c, d; //coeffs of ax^3 + bx^2 + cx + d
            int minX, maxX; //defines domain
            double val; //value of polynomial x
            string doAgain;

            do
            {
                try
                {
                    Write("Enter the degree of the polynomial: ");
                    degree = int.Parse(ReadLine());
                    if (degree == 1) //f(x) = cx + d
                    {
                        a = 0;
                        b = 0;
                    } else if (degree == 2) //f(x) = bx^2 + cx + d 
                    {
                        a = 0;
                        Write("Enter b: ");
                        b = double.Parse(ReadLine());
                    } else //f(x) = ax^3 + bx^2 + cx + d
                    {
                        Write("Enter a: ");
                        a = double.Parse(ReadLine());
                        Write("Enter b: ");
                        b = double.Parse(ReadLine());
                    }
                    Write("Enter c: ");
                    c = double.Parse(ReadLine());
                    Write("Enter d: ");
                    d = double.Parse(ReadLine());

                    //define domain
                    Write("Enter min x: ");
                    minX = int.Parse(ReadLine());
                    Write("Enter max x: ");
                    maxX = int.Parse(ReadLine());
                    if (minX > maxX)
                    {
                        int temp = minX;
                        minX = maxX;
                        maxX = temp;
                    }

                    //output function values
                    WriteLine($"Here is the function computed over {minX} to {maxX}: ");
                    WriteLine($"{"x",10} {"y",10}");
                    for (int x = minX; x <= maxX; x++)
                    {
                        val = a * Math.Pow(x, 3) + b * Math.Pow(x, 2) + c * Math.Pow(x, 1) + d;
                        WriteLine($"{x,10}{val,10:F3}");
                    }
                } catch (Exception e)
                {
                    WriteLine("You have to enter a number for all questions");
                }
                WriteLine();
                Write("Do you want to enter another polynomial? ");
                doAgain = ReadLine().ToLower().Trim();
            } while (doAgain == "y");
            WriteLine("Thank you for using this program.");
        }
    }
}
