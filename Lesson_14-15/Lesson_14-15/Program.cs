using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14_15
{
    using System;
    using System.Collections.Generic;

    namespace ConsoleApp1
    {
        internal class Program
        {
            // Делегат
            delegate void MessageHandler(string message);

            // Методы обработки

            static void Normal(string msg)
            {
                Console.WriteLine(msg);
            }

            static void Upper(string msg)
            {
                Console.WriteLine(msg.ToUpper());
            }

            static void WithTime(string msg)
            {
                Console.WriteLine($"{msg} [{DateTime.Now}]");
            }

            static void WithStars(string msg)
            {
                Console.WriteLine($"*** {msg} ***");
            }

            static void Main(string[] args)
            {
                Console.Write("Введите сообщение: ");
                string message = Console.ReadLine();

                Console.WriteLine("Выбор:");
                Console.WriteLine("1 - Обычный");
                Console.WriteLine("2 - Верхний регистр");
                Console.WriteLine("3 - С временем");
                Console.WriteLine("4 - Со звездами");

                int choice = int.Parse(Console.ReadLine());

                MessageHandler handler = null;

                switch (choice)
                {
                    case 1:
                        handler = Normal;
                        break;
                    case 2:
                        handler = Upper;
                        break;
                    case 3:
                        handler = WithTime;
                        break;
                    case 4:
                        handler = WithStars;
                        break;
                    default:
                        Console.WriteLine("Ошибка выбора");
                        return;
                }

                // Вызов через список делегатов (как у тебя)
                foreach (MessageHandler h in handler.GetInvocationList())
                {
                    h(message);
                }
            }
        }
    }
}
