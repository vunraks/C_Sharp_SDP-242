using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13_14
{
    //abstract class Animal
    //{
    //    protected string Name;
    //    public string Name_gs
    //    {
    //        get
    //        {
    //            return Name;
    //        }
    //        set
    //        {
    //            Name = value;
    //        }
    //    }

    //    public Animal(string name)
    //    {
    //        this.Name = name;
    //    }

    //    public abstract void MakeSound();
    //}

    //interface IRun
    //{
    //    void Run();
    //}
    //interface ISwim
    //{
    //    void Swim();
    //}

    //class Lion : Animal, IRun
    //{
    //    public Lion(string name) : base(name)
    //    {
    //        this.Name = name;
    //    }
    //    public override void MakeSound()
    //    {
    //        Console.WriteLine($"{Name}:Roar!");
    //    }
    //    public void Run()
    //    {
    //        Console.WriteLine($"{Name}: is running.");
    //    }
    //}
    //class Fish : Animal, ISwim
    //{
    //    public Fish(string name) : base(name) { }

    //    public override void MakeSound()
    //    {
    //        Console.WriteLine($"{Name}: Blub!");
    //    }
    //    public void Swim()
    //    {
    //        Console.WriteLine($"{Name}: is swimming.");
    //    }
    //}

    //class Duck : Animal, IRun, ISwim
    //{
    //    public Duck(string name) : base(name) { }
    //    public override void MakeSound()
    //    {
    //        Console.WriteLine($"{Name}: Quack!");
    //    }
    //    public void Run()
    //    {
    //        Console.WriteLine($"{Name}: is running.");
    //    }
    //    public void Swim()
    //    {
    //        Console.WriteLine($"{Name}: is swimming.");
    //    }
    //}

    //class ZooKeeper
    //{
    //    public void FeedAnimal(Animal animal)
    //    {
    //        Console.WriteLine($"Feeding {animal.Name_gs}...");
    //    }
    //    public void MakeAnimalSound(Animal animal)
    //    {
    //        animal.MakeSound();
    //    }
    //}
    //internal class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        //ZooKeeper zooKeeper = new ZooKeeper();
    //        //Lion lion = new Lion("Leo");
    //        //Fish fish = new Fish("Nemo");
    //        //Duck duck = new Duck("Donald");
    //        //zooKeeper.FeedAnimal(lion);
    //        //zooKeeper.MakeAnimalSound(lion);
    //        //lion.Run();
    //        //zooKeeper.FeedAnimal(fish);
    //        //zooKeeper.MakeAnimalSound(fish);
    //        //fish.Swim();
    //        //zooKeeper.FeedAnimal(duck);
    //        //zooKeeper.MakeAnimalSound(duck);
    //        //duck.Run();
    //        //duck.Swim();


    //        List<Animal> animals = new List<Animal>
    //        {
    //            new Lion("Leo"),
    //            new Fish("Nemo"),
    //            new Duck("Donald")
    //        };

    //        ZooKeeper zooKeeper = new ZooKeeper();

    //        foreach (var animal in animals)
    //        {
    //            zooKeeper.MakeAnimalSound(animal);

    //            if (animal is IRun runner) 
    //            {
    //                runner.Run();
    //            }
    //            if (animal is ISwim swimmer)
    //            {
    //                swimmer.Swim();
    //            }
    //            zooKeeper.FeedAnimal(animal);
    //            Console.WriteLine("-------------------------");

    //        }
    //    }
    //}


    interface ICompletable
    {
        void Complete();
    }

    class Task : ICompletable
    {
        public string Title;
        public bool IsDone;

        public Task(string title)
        {
            this.Title = title;
            this.IsDone = false;
        }
        public void Complete()
        {
            IsDone = true;
        }
        public virtual void Show()
        {
            string status = IsDone ? "[+]" : "[]";
            Console.WriteLine($"{status} {Title}");
        }

    }
    class TimedTask : Task
    {
        public DateTime DeadLine;
        public TimedTask(string title, DateTime deadline) : base(title)
        {
            this.DeadLine = deadline;
        }
        public override void Show()
        {
            string status = IsDone ? "[+]" : "[]";
            Console.WriteLine($"{status} {Title} (Due: {DeadLine.ToShortDateString()})");
        }
    }

    internal class Program
    {
        static List<Task> tasks = new List<Task>();
        static void Main(string[] args)
        {
            bool is_Running = true;
            while (is_Running)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("1.Добавить задачу");
                Console.WriteLine("2.Выполнить задачу");
                Console.WriteLine("3.Удалить задачу");
                Console.WriteLine("4.Показать задачи");
                Console.WriteLine("0.Выход\n");

                Console.Write("Выберите действие: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        CompleteTask();
                        break;
                    case "3":
                        DeleteTask();
                        break;
                    case "4":
                        ShowTasks();
                        break;
                    case "0":
                        is_Running = false;
                        break;
                }

            }
        }

        static void AddTask()
        {
            Console.Write("Введите название задачи: ");
            string title = Console.ReadLine();
            Console.Write("Есть ли дедлайн? (y/n): ");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "y")
            {
                Console.Write("Введите дату дедлайна (yyyy-MM-dd): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                tasks.Add(new TimedTask(title, date));
            }
            else
            {
                tasks.Add(new Task(title));
            }
        }
        static void CompleteTask()
        {
            Console.Write("Введите номер задачи для выполнения: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index >= 0 && index < tasks.Count)
            {
                tasks[index].Complete();
            }
        }
        static void DeleteTask()
        {
            Console.Write("Введите номер задачи для удаления: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
            }
        }
        static void ShowTasks()
        {
            var sortedTasks = tasks
                    .OrderBy(t =>
                    {
                        if (t is TimedTask timed)
                            return timed.DeadLine;
                        return DateTime.MaxValue;
                    })
                    .ToList();

            for (int i = 0; i < sortedTasks.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                sortedTasks[i].Show();
            }
        }
    }
}
