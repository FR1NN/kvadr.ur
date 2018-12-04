using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c;
            const Double eps = 1.0E-6; //точность

            Console.Write("a = ");
            a = Vvod(args, 0);
            Console.WriteLine(";");

            Console.Write("b = ");
            b = Vvod(args, 1);
            Console.WriteLine(";");

            Console.Write("c = ");
            c = Vvod(args, 2);
            Console.WriteLine(";");

            Console.WriteLine("коэффициенты введены корректно");

            if (eps < Math.Abs(a))
            {
                Console.WriteLine("Квадратное уравнение {0}*x^2 +{1}*x + {2} = 0", a, b, c);
                Double d = b * b - 4 * a * c;
                if (d < -eps)
                //нет решений
                {
                    Console.WriteLine("вещественных решений нет");
                }
                else if (Math.Abs(d) < eps)
                //одно решение
                {
                    Double x = -b / (2 * a);
                    Console.WriteLine("одно вещественное решение x = {0}", x);
                }
                else
                //два решения
                {
                    Console.WriteLine("два вещественных решения x1 = {0} x2 = {1}",
                        (-b - Math.Sqrt(d)) / (2 * a), (-b + Math.Sqrt(d)) / (2 * a));
                }
            }
            else if (eps < Math.Abs(b))
            //линейное уравнение
            {
                Console.WriteLine("линейное уравнение {0}*x+{1}=0, одно решение x={2}", b, c, -c / b);
            }
            else
            //вырожденный случай
            {
                if (Math.Abs(c) < eps)
                {
                    Console.WriteLine("тождественное равенство 0=0");
                }
                else
                {
                    Console.WriteLine("неверное тождество {0}=0", c);
                }
            }
            Console.ReadKey();
        }

        public static double Vvod(string[] args, int i) //использования для ввода параметров командной строки
        {
            double d;
            try
            {
                
                if (args.Length != 3)
                {
                    d = Convert.ToDouble(Console.ReadLine());

                }
                else
                    d = Convert.ToDouble(args[i]);
            }

            catch
            {
                Console.WriteLine("неверный ввод, повторите попытку");
                d = Vvod(args, i);

            }
            return d;
        }
    }
}

