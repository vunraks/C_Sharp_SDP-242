using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    class Program
    {



        // ================= ЗАДАНИЕ 1 =================
        delegate double Operation(double a, double b);

        static double Add(double a, double b) => a + b;
        static double Sub(double a, double b) => a - b;
        static double Mul(double a, double b) => a * b;
        static double Div(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }

        static void Calculator()
        {
            try
            {
                Console.WriteLine("\n1 (+)  2 (-)  3 (*)  4 (/)");
                Console.Write("Выбор: ");
                string choice = Console.ReadLine();

                Console.Write("a: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("b: ");
                double b = double.Parse(Console.ReadLine());

                Operation op = null;

                if (choice == "1") op = Add;
                else if (choice == "2") op = Sub;
                else if (choice == "3") op = Mul;
                else if (choice == "4") op = Div;
                else
                {
                    Console.WriteLine("Ошибка выбора");
                    return;
                }

                double result = op(a, b);
                Console.WriteLine("Результат: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }

        // ================= ЗАДАНИЕ 2 =================
        static void Print(string s) => Console.WriteLine(s);

        static void ToUpper(string s) => Console.WriteLine(s.ToUpper());

        static void WithTime(string s) =>
            Console.WriteLine($"{DateTime.Now}: {s}");

        static void ActionExample()
        {
            Action<string> act = null;

            act += Print;
            act += ToUpper;
            act += WithTime;

            act("hello world");
        }

        // ================= ЗАДАНИЕ 3 =================
        static void FuncExample()
        {
            Func<int, int> square = x => x * x;
            Func<int, bool> check = x => x > 10;

            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());

            if (check(n))
                Console.WriteLine("Квадрат: " + square(n));
            else
                Console.WriteLine("Число слишком маленькое");
        }

        // ================= ЗАДАНИЕ 4 =================
        static void PredicateExample()
        {
            List<int> nums = new List<int> { 1, 2, 3, 6, 7, 8, 10 };

            Predicate<int> isEven = x => x % 2 == 0;
            Predicate<int> greater5 = x => x > 5;

            Console.WriteLine("Чётные:");
            foreach (int n in nums)
            {
                if (isEven(n))
                    Console.Write(n + " ");
            }

            Console.WriteLine("\nБольше 5:");
            foreach (int n in nums)
            {
                if (greater5(n))
                    Console.Write(n + " ");
            }

            Console.WriteLine();
        }

        // ================= ЗАДАНИЕ 5 =================
        static void ListProcessing()
        {
            List<int> nums = new List<int>
        {
            1,2,3,4,5,6,7,8,9,10,12,15
        };

            Func<int, int> transform = x => x * 2;
            Predicate<int> filter = x => x % 2 == 0;
            Action<int> print = x => Console.Write(x + " ");

            Console.WriteLine("Результат:");

            foreach (int n in nums)
            {
                if (filter(n))
                {
                    int changed = transform(n);
                    print(changed);
                }
            }

            Console.WriteLine();
        }

            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("\n=== МЕНЮ ===");
                    Console.WriteLine("1. Калькулятор");
                    Console.WriteLine("2. Action");
                    Console.WriteLine("3. Func");
                    Console.WriteLine("4. Predicate");
                    Console.WriteLine("5. Обработка списка");
                    Console.WriteLine("0. Выход");

                    Console.Write("Выбор: ");
                    string c = Console.ReadLine();

                    if (c == "1") Calculator();
                    else if (c == "2") ActionExample();
                    else if (c == "3") FuncExample();
                    else if (c == "4") PredicateExample();
                    else if (c == "5") ListProcessing();
                    else if (c == "0") break;
                    else Console.WriteLine("Ошибка");
                }
            }
        }
    }

