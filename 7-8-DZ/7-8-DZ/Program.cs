using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_8_DZ
{

    class Program
    {
        // ================= ЗАДАНИЕ 1 =================
        static void ConvertNumber()
        {
            try
            {
                Console.WriteLine("1 - Десятичная -> Двоичная");
                Console.WriteLine("2 - Двоичная -> Десятичная");
                Console.Write("Выбор: ");
                int choice = int.Parse(Console.ReadLine());

                Console.Write("Введите число: ");
                string input = Console.ReadLine();

                if (choice == 1)
                {
                    int num = int.Parse(input);
                    Console.WriteLine("Результат: " + Convert.ToString(num, 2));
                }
                else if (choice == 2)
                {
                    int num = Convert.ToInt32(input, 2);
                    Console.WriteLine("Результат: " + num);
                }
                else
                {
                    Console.WriteLine("Неверный выбор");
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: число слишком большое!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неправильный ввод!");
            }
        }

        // ================= ЗАДАНИЕ 2 =================
        static void WordToNumber()
        {
            try
            {
                Console.Write("Введите число словами (0-9): ");
                string word = Console.ReadLine().ToLower();

                Dictionary<string, int> map = new Dictionary<string, int>()
            {
                {"zero",0},{"one",1},{"two",2},{"three",3},{"four",4},
                {"five",5},{"six",6},{"seven",7},{"eight",8},{"nine",9}
            };

                if (map.ContainsKey(word))
                    Console.WriteLine("Результат: " + map[word]);
                else
                    throw new Exception("Неизвестное слово!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }

        // ================= ЗАДАНИЕ 3 =================
        class Passport
        {
            public string Number { get; set; }
            public string FullName { get; set; }
            public DateTime IssueDate { get; set; }

            public Passport(string number, string name, DateTime date)
            {
                if (string.IsNullOrWhiteSpace(number))
                    throw new Exception("Номер паспорта пуст!");

                if (string.IsNullOrWhiteSpace(name))
                    throw new Exception("ФИО пустое!");

                if (date > DateTime.Now)
                    throw new Exception("Дата не может быть в будущем!");

                Number = number;
                FullName = name;
                IssueDate = date;
            }

            public void Print()
            {
                Console.WriteLine($"Паспорт: {Number}, ФИО: {FullName}, Дата выдачи: {IssueDate.ToShortDateString()}");
            }
        }

        // ================= ЗАДАНИЕ 4 =================
        static void EvaluateExpression()
        {
            try
            {
                Console.Write("Введите выражение (например 3>2): ");
                string expr = Console.ReadLine();

                string op = "";

                if (expr.Contains("<=")) op = "<=";
                else if (expr.Contains(">=")) op = ">=";
                else if (expr.Contains("==")) op = "==";
                else if (expr.Contains("!=")) op = "!=";
                else if (expr.Contains("<")) op = "<";
                else if (expr.Contains(">")) op = ">";
                else throw new Exception("Неверный оператор!");

                string[] parts = expr.Split(new string[] { op }, StringSplitOptions.None);

                if (parts.Length != 2)
                    throw new Exception("Ошибка разбора выражения!");

                int a = int.Parse(parts[0]);
                int b = int.Parse(parts[1]);

                bool result = false;

                switch (op)
                {
                    case "<":
                        result = a < b;
                        break;
                    case ">":
                        result = a > b;
                        break;
                    case "<=":
                        result = a <= b;
                        break;
                    case ">=":
                        result = a >= b;
                        break;
                    case "==":
                        result = a == b;
                        break;
                    case "!=":
                        result = a != b;
                        break;
                    default:
                        throw new Exception("Неизвестный оператор!");
                }

                Console.WriteLine("Результат: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: вводите только числа!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }

        // ================= MAIN =================
        static void Main()
        {
            Console.WriteLine("=== Задание 1 ===");
            ConvertNumber();

            Console.WriteLine("\n=== Задание 2 ===");
            WordToNumber();

            Console.WriteLine("\n=== Задание 3 ===");
            try
            {
                Passport p = new Passport("KZ123456", "Иван Иванов", DateTime.Parse("2020-05-10"));
                p.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.WriteLine("\n=== Задание 4 ===");
            EvaluateExpression();
        }
    }

}
