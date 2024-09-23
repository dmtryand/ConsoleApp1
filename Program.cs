using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static double Factorial(double n) 
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
       


        public static void Function(double x)
        {
            if (x < 54 || Math.Sin(Math.Pow(x,2)) == 0)
            {
                Console.WriteLine("не удовлетворяет области определения");
            }
            else
            {
                double a = Math.Sqrt(x - 54) + (Math.Cos(x / 2) / Math.Sin(Math.Pow(x, 2))) - Math.Log(x);
                Console.WriteLine("A = " + a);
            }
            
        }


        public static int Fibonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n-2);
            }
        }

        public static void Taylor(int accuracy, double x)
        {
            int n = 0;
            double a = (Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1)) / (Factorial(2 * n + 1));
            string[] amass = new string[2];
            if (a == 1)
            {
                Console.WriteLine(a);
                amass[0] = "0";
                amass[1] = "00000000";
            }
            else
            {
                amass = a.ToString().Split(',');
            }
            
            string astr = amass[1];
            if (accuracy == 0)
            {
                Console.WriteLine("ответ " + a);
            }
            else
            {
                bool y = true;
                while (y)
                {
                    n++;
                    double a1 = (Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1)) / (Factorial(2 * n + 1));
                    string[] amass1 = new string[2];
                    amass1 = a1.ToString().Split(',');
                    string astr1 = amass1[1];
                    if (astr1[accuracy - 1] == astr[accuracy - 1])
                    {
                        Console.WriteLine("ответ " + a1);
                        y = false;
                    }
                    else
                    {
                        astr = astr1;
                    }
                }
            }
            
        }


        static void Main(string[] args)
        {
            bool z = true;
            
            while (z)
            {
                Console.WriteLine("выбери задание:\n" +
                "1 - задание 1\n" +
                "2 - задание 2\n" +
                "3 - задание 3\n" +
                "4 - задание 4\n" +
                "5 - выйти");
                int deal = int.Parse(Console.ReadLine());
                switch(deal)
                {
                    case 1:
                        Console.WriteLine("Напиши n");
                        int f = int.Parse(Console.ReadLine());
                        Console.WriteLine(Factorial(f));
                        break;
                    case 2:
                        Console.WriteLine("Введи х");
                        double x = double.Parse(Console.ReadLine());
                        Function(x);
                        break;
                    case 3:
                        Console.WriteLine("введи число n");
                        int d = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= d; i++)
                        {
                            if (Fibonacci(i) >= d)
                            { break; }
                            Console.WriteLine(Fibonacci(i));

                        }
                        break;
                    case 4:
                        Console.WriteLine("Напиши точность");
                        int accuracy = int.Parse(Console.ReadLine());
                        double s = 1;
                        Taylor(accuracy, s);
                        break;
                    case 5:
                        z = false; 
                        break;
                }
                
            }

        }
    }
}
