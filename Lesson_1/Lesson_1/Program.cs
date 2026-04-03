using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = -0567569999;
            //byte number2 = 0;
            //float number1 = 2.5f;
            //double number2 = 2.51d;
            //Console.WriteLine(number2+number1);

            //string name = "John";
            //char symbol= 'A';
            //bool isTrue = true;

            //Console.Write("Enter your name:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Welcom, " + name);

            //Console.WriteLine(char.IsDigit('1'));
            //Console.WriteLine(char.IsControl('\n'));

            //int? number = null;
            //string str = "null   g";
            //Console.WriteLine(number);
            //if (number == null)
            //{ 
            //    number = 5;
            //}
            //Console.WriteLine(str);

            //int x = 5;
            //float y = 2.5f;

            //int b = x + y;
            //Console.WriteLine(b);

            //int[] numbers = new int[5];
            //int sum = 0;
            //int oddCount = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"Введите число: {i + 1}");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Вы ввели следующие числа:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];

            //    if (numbers[i] % 2 != 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //    else
            //    {
            //        oddCount++;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Сумма чисел: " + sum);
            //Console.WriteLine(oddCount);

            Random rand = new Random();
            int secret = rand.Next(1, 16);
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("Угадайте число от 1 до 15!");

            while (guess != secret)
            {
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < secret)
                    Console.WriteLine("Больше!");
                else if (guess > secret)
                    Console.WriteLine("Меньше!");
                else
                    Console.WriteLine($"Поздравляем! Вы угадали число за {attempts} попыток!");
            }



        }
    }
}
