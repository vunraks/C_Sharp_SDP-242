using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_10_DZ
{
    using System;

    // ================= ЗАДАНИЕ 1 =================
    class Money
    {
        protected int whole;   // доллары
        protected int cents;   // центы

        public Money(int whole, int cents)
        {
            this.whole = whole;
            this.cents = cents;
        }

        public void SetMoney(int whole, int cents)
        {
            this.whole = whole;
            this.cents = cents;
        }

        public void Print()
        {
            Console.WriteLine($"{whole}.{cents:D2}");
        }
    }

    class Product : Money
    {
        private string name;

        public Product(string name, int whole, int cents) : base(whole, cents)
        {
            this.name = name;
        }

        public void DecreasePrice(int amount)
        {
            int total = whole * 100 + cents;
            total -= amount;

            if (total < 0) total = 0;

            whole = total / 100;
            cents = total % 100;
        }

        public void PrintProduct()
        {
            Console.Write($"{name}: ");
            Print();
        }
    }

    // ================= ЗАДАНИЕ 2 =================
    class Device
    {
        protected string name;
        protected string description;

        public Device(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Устройство издает звук");
        }

        public virtual void Show()
        {
            Console.WriteLine("Название: " + name);
        }

        public virtual void Desc()
        {
            Console.WriteLine("Описание: " + description);
        }
    }

    class Kettle : Device
    {
        public Kettle() : base("Чайник", "Кипятит воду") { }

        public override void Sound() => Console.WriteLine("Свист чайника");
    }

    class Microwave : Device
    {
        public Microwave() : base("Микроволновка", "Разогревает еду") { }

        public override void Sound() => Console.WriteLine("Жужжание микроволновки");
    }

    class Car : Device
    {
        public Car() : base("Автомобиль", "Средство передвижения") { }

        public override void Sound() => Console.WriteLine("Бип-бип");
    }

    class Steamboat : Device
    {
        public Steamboat() : base("Пароход", "Передвигается по воде") { }

        public override void Sound() => Console.WriteLine("Гудок парохода");
    }

    // ================= ЗАДАНИЕ 3 =================
    class MusicalInstrument
    {
        protected string name;
        protected string description;

        public MusicalInstrument(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Звук инструмента");
        }

        public virtual void Show()
        {
            Console.WriteLine("Инструмент: " + name);
        }

        public virtual void Desc()
        {
            Console.WriteLine("Описание: " + description);
        }

        public virtual void History()
        {
            Console.WriteLine("История инструмента");
        }
    }

    class Violin : MusicalInstrument
    {
        public Violin() : base("Скрипка", "Струнный инструмент") { }

        public override void Sound() => Console.WriteLine("Скрипичный звук");
        public override void History() => Console.WriteLine("Появилась в XVI веке");
    }

    class Trombone : MusicalInstrument
    {
        public Trombone() : base("Тромбон", "Духовой инструмент") { }

        public override void Sound() => Console.WriteLine("Тромбон: буу");
        public override void History() => Console.WriteLine("Известен с XV века");
    }

    class Ukulele : MusicalInstrument
    {
        public Ukulele() : base("Укулеле", "Маленькая гитара") { }

        public override void Sound() => Console.WriteLine("Тынь-тынь");
        public override void History() => Console.WriteLine("Родом из Гавайев");
    }

    class Cello : MusicalInstrument
    {
        public Cello() : base("Виолончель", "Крупный струнный инструмент") { }

        public override void Sound() => Console.WriteLine("Глубокий звук");
        public override void History() => Console.WriteLine("XV-XVI века Европа");
    }

    // ================= ЗАДАНИЕ 4 =================
    abstract class Worker
    {
        public abstract void Print();
    }

    class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Президент управляет компанией");
        }
    }

    class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Охранник следит за безопасностью");
        }
    }

    class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Менеджер управляет процессами");
        }
    }

    class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Инженер разрабатывает решения");
        }
    }

    // ================= MAIN =================
    class Program
    {
        static void Main()
        {
            // ---- ЗАДАНИЕ 1 ----
            Console.WriteLine("=== Money / Product ===");
            Product p = new Product("Телефон", 100, 50);
            p.PrintProduct();
            p.DecreasePrice(2500); // уменьшили на 25.00
            p.PrintProduct();

            // ---- ЗАДАНИЕ 2 ----
            Console.WriteLine("\n=== Device ===");
            Device[] devices = { new Kettle(), new Microwave(), new Car(), new Steamboat() };

            foreach (Device d in devices)
            {
                d.Show();
                d.Desc();
                d.Sound();
                Console.WriteLine();
            }

            // ---- ЗАДАНИЕ 3 ----
            Console.WriteLine("=== Instruments ===");
            MusicalInstrument[] instruments = { new Violin(), new Trombone(), new Ukulele(), new Cello() };

            foreach (var i in instruments)
            {
                i.Show();
                i.Desc();
                i.Sound();
                i.History();
                Console.WriteLine();
            }

            // ---- ЗАДАНИЕ 4 ----
            Console.WriteLine("=== Workers ===");
            Worker[] workers = { new President(), new Security(), new Manager(), new Engineer() };

            foreach (var w in workers)
            {
                w.Print();
            }
        }
    }
}
