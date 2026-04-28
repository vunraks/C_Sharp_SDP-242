using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13_14_
{
    class TaskItem
    {
        public string Title;
        public string Category;
        public DateTime? Deadline;

        public bool IsOverdue()
        {
            return Deadline.HasValue && Deadline.Value < DateTime.Now;
        }

        public void Print(int index)
        {
            string status = IsOverdue() ? "[-]" : "[ ]";
            string date = Deadline.HasValue ? Deadline.Value.ToString("dd.MM.yyyy HH:mm") : "нет";

            Console.WriteLine($"{index}. {status} {Title} | {Category} | {date}");
        }
    }

    internal class Program
    {
        static List<TaskItem> tasks = new List<TaskItem>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n1. Добавить");
                Console.WriteLine("2. Показать все");
                Console.WriteLine("3. Фильтр по дедлайну");
                Console.WriteLine("4. По категории");
                Console.WriteLine("5. Редактировать");
                Console.WriteLine("0. Выход");

                Console.Write("Выбор: ");
                string choice = Console.ReadLine();

                if (choice == "1") AddTask();
                else if (choice == "2") ShowTasks(tasks);
                else if (choice == "3") FilterByDeadline();
                else if (choice == "4") FilterByCategory();
                else if (choice == "5") EditTask();
                else if (choice == "0") break;
                else Console.WriteLine("Ошибка");
            }
        }

        // ===== ДОБАВИТЬ =====
        static void AddTask()
        {
            TaskItem t = new TaskItem();

            Console.Write("Название: ");
            t.Title = Console.ReadLine();

            Console.Write("Категория: ");
            t.Category = Console.ReadLine();

            Console.Write("Дедлайн (пусто = нет): ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                DateTime dt;
                if (DateTime.TryParse(input, out dt))
                    t.Deadline = dt;
                else
                    Console.WriteLine("Ошибка даты");
            }

            tasks.Add(t);
        }

        // ===== ВЫВОД =====
        static void ShowTasks(List<TaskItem> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Нет задач");
                return;
            }

            for (int i = 0; i < list.Count; i++)
            {
                list[i].Print(i);
            }
        }

        // ===== ФИЛЬТР ПО ДЕДЛАЙНУ =====
        static void FilterByDeadline()
        {
            List<TaskItem> withDeadline = new List<TaskItem>();
            List<TaskItem> withoutDeadline = new List<TaskItem>();

            foreach (var t in tasks)
            {
                if (t.Deadline.HasValue)
                    withDeadline.Add(t);
                else
                    withoutDeadline.Add(t);
            }

            withDeadline.Sort((a, b) => a.Deadline.Value.CompareTo(b.Deadline.Value));

            Console.WriteLine("\nС дедлайном:");
            ShowTasks(withDeadline);

            Console.WriteLine("\nБез дедлайна:");
            ShowTasks(withoutDeadline);
        }

        // ===== ПО КАТЕГОРИИ =====
        static void FilterByCategory()
        {
            List<string> categories = new List<string>();

            foreach (var t in tasks)
            {
                if (!categories.Contains(t.Category))
                    categories.Add(t.Category);
            }

            if (categories.Count == 0)
            {
                Console.WriteLine("Нет категорий");
                return;
            }

            for (int i = 0; i < categories.Count; i++)
            {
                Console.WriteLine($"{i}. {categories[i]}");
            }

            Console.Write("Выбор: ");
            int index;

            if (!int.TryParse(Console.ReadLine(), out index) ||
                index < 0 || index >= categories.Count)
            {
                Console.WriteLine("Ошибка");
                return;
            }

            string selected = categories[index];
            List<TaskItem> result = new List<TaskItem>();

            foreach (var t in tasks)
            {
                if (t.Category == selected)
                    result.Add(t);
            }

            ShowTasks(result);
        }

        // ===== РЕДАКТИРОВАНИЕ =====
        static void EditTask()
        {
            ShowTasks(tasks);

            Console.Write("Номер задачи: ");
            int index;

            if (!int.TryParse(Console.ReadLine(), out index) ||
                index < 0 || index >= tasks.Count)
            {
                Console.WriteLine("Ошибка");
                return;
            }

            TaskItem t = tasks[index];

            Console.Write("Новое название (Enter - пропуск): ");
            string title = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(title))
                t.Title = title;

            Console.Write("Новая категория (Enter - пропуск): ");
            string cat = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(cat))
                t.Category = cat;

            Console.Write("Новый дедлайн (Enter - пропуск): ");
            string date = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(date))
            {
                DateTime dt;
                if (DateTime.TryParse(date, out dt))
                    t.Deadline = dt;
                else
                    Console.WriteLine("Ошибка даты");
            }

            Console.WriteLine("Готово!");
        }
    }
}
    

