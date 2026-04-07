using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_5_DZ
{
    using System;
    using System.Linq;

    class Program
    {
        // ================= ЗАДАНИЕ 1 =================
        static void DrawSquare(int size, char symbol)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
        }

        // ================= ЗАДАНИЕ 2 =================
        static bool IsPalindrome(int number)
        {
            string str = number.ToString();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);

            return str == reversed;
        }

        // ================= ЗАДАНИЕ 3 =================
        static int[] FilterArray(int[] original, int[] filter)
        {
            return original.Where(x => !filter.Contains(x)).ToArray();
        }

        static void PrintArray(int[] arr)
        {
            foreach (int x in arr)
                Console.Write(x + " ");
            Console.WriteLine();
        }

        // ================= ЗАДАНИЕ 4 =================
        class Website
        {
            private string name;
            private string path;
            private string description;
            private string ip;

            public void Input()
            {
                Console.Write("Название: ");
                name = Console.ReadLine();

                Console.Write("Путь: ");
                path = Console.ReadLine();

                Console.Write("Описание: ");
                description = Console.ReadLine();

                Console.Write("IP: ");
                ip = Console.ReadLine();
            }

            public void Print()
            {
                Console.WriteLine($"Сайт: {name}, Путь: {path}, Описание: {description}, IP: {ip}");
            }

            public string GetName() => name;
            public void SetName(string value) => name = value;
        }

        // ================= ЗАДАНИЕ 5 =================
        class Journal
        {
            private string name;
            private int year;
            private string description;
            private string phone;
            private string email;

            public void Input()
            {
                Console.Write("Название журнала: ");
                name = Console.ReadLine();

                Console.Write("Год основания: ");
                year = int.Parse(Console.ReadLine());

                Console.Write("Описание: ");
                description = Console.ReadLine();

                Console.Write("Телефон: ");
                phone = Console.ReadLine();

                Console.Write("Email: ");
                email = Console.ReadLine();
            }

            public void Print()
            {
                Console.WriteLine($"Журнал: {name}, Год: {year}, Описание: {description}, Телефон: {phone}, Email: {email}");
            }

            public string GetName() => name;
            public void SetName(string value) => name = value;
        }

        // ================= ЗАДАНИЕ 6 =================
        class Shop
        {
            private string name;
            private string address;
            private string description;
            private string phone;
            private string email;

            public void Input()
            {
                Console.Write("Название магазина: ");
                name = Console.ReadLine();

                Console.Write("Адрес: ");
                address = Console.ReadLine();

                Console.Write("Описание: ");
                description = Console.ReadLine();

                Console.Write("Телефон: ");
                phone = Console.ReadLine();

                Console.Write("Email: ");
                email = Console.ReadLine();
            }

            public void Print()
            {
                Console.WriteLine($"Магазин: {name}, Адрес: {address}, Описание: {description}, Телефон: {phone}, Email: {email}");
            }

            public string GetName() => name;
            public void SetName(string value) => name = value;
        }

        // ================= MAIN =================
        static void Main()
        {
            // ---- ЗАДАНИЕ 1 ----
            Console.WriteLine("Квадрат:");
            DrawSquare(4, '#');

            // ---- ЗАДАНИЕ 2 ----
            Console.WriteLine("\nПалиндром:");
            Console.WriteLine(IsPalindrome(1221)); // true
            Console.WriteLine(IsPalindrome(7854)); // false

            // ---- ЗАДАНИЕ 3 ----
            Console.WriteLine("\nФильтрация массива:");
            int[] original = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filter = { 6, 88, 7 };

            int[] result = FilterArray(original, filter);
            PrintArray(result);

            // ---- ЗАДАНИЕ 4 ----
            Console.WriteLine("\nСайт:");
            Website site = new Website();
            site.Input();
            site.Print();

            // ---- ЗАДАНИЕ 5 ----
            Console.WriteLine("\nЖурнал:");
            Journal journal = new Journal();
            journal.Input();
            journal.Print();

            // ---- ЗАДАНИЕ 6 ----
            Console.WriteLine("\nМагазин:");
            Shop shop = new Shop();
            shop.Input();
            shop.Print();
        }
    }

}
