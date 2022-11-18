using System;

namespace Методы2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, sum;

            Console.WriteLine("Введите первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToInt32(Console.ReadLine());

            sum = a + b;
            Console.WriteLine("Ответ: " + sum);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            float c, d, multiply;

            Console.WriteLine("Введите первое число");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            d = Convert.ToInt32(Console.ReadLine());

            multiply = c * d;
            Console.WriteLine("Ответ: " + multiply);
        }

        public void Sum(float sum)
        {
            Console.WriteLine(+sum);
        }

        private void Mult(float multiply)
        {
            Console.WriteLine(+multiply);
        }


    }
}
