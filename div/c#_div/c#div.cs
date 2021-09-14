using System;

namespace Div
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Пожалуйста введите первое число!");
                double n1 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Пожалуйста введите второе число");
                double n2 = Int32.Parse(Console.ReadLine());


                if (n1 == 0)

                    Console.WriteLine("На ноль делить нельзя!");



                if (n2 == 0)
                    Console.WriteLine("На ноль делить нельзя!");
                else
                    Console.WriteLine($"Результат: {n1 / n2}");
            }
            catch
            {

                Console.WriteLine("Вы ввели не число!");
            }
            finally
            {
                Console.WriteLine("Конец программы!");
            }

            Console.ReadKey();
        }
    }
}
