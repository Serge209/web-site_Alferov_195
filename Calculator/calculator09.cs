using System;

namespace calculator09
{
    public class Class1
    {
        public int Plus(string d, int n1, int n2)
        {
            if ((d == "+") || (d == "Сложение"))
            {
                
                return n1 + n2;

            }
            else return 0;
            //return n1 + n2;
        }

        public static void Main(string[] args)
        {
            double res, n2;
            string d;
            int n1;
            Console.WriteLine("Введите арифметичкую операцию(+,-,*,/,Возведение в степень,Извлечение корня)");
            d = Console.ReadLine();


          int Plus(string d, int n1, int n2)
            {
                if ((d == "+") || (d == "Сложение"))
                {
                    Console.WriteLine("Введите первое число");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(n1 + n2);
                   
                }
                return n1 + n2;
            }
          
            void Minus(string d, int n1, int n2)
            {
                if ((d == "-") || (d == "Вычитание"))
                {
                    Console.WriteLine("Введите первое число");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(n1 - n2);
                }
            }

            void Umn(string d, int n1, int n2)
            {
                if ((d == "*") || (d == "Умножение"))
                {
                    Console.WriteLine("Введите первое число");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(res = n1 * n2);
                }
            }

            void Div(string d, int n1, int n2)
            {
                if ((d == "/") || (d == "Деление"))
                {
                    Console.WriteLine("Введите первое число");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    try
                    {


                        if (n2 == 0)
                        {
                            throw new Exception();
                        }

                    }
                    catch
                    {

                        Console.WriteLine("Division of {0} by zero.", n1);
                    }
                }
            }

            void Pow(string d, int n1, int n2)
            {
                if ((d == "pow") || (d == "Возведение в степень"))
                {
                    Console.WriteLine("Введите первое число");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    res = Math.Pow(n1, n2);
                    res.ToString("0.00");

                    Console.WriteLine(res);
                }
            }


        }
    }
}

