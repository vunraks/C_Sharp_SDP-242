using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_12
{
    //class Point
    //{
    //    private int x;


    //    public void SetX(int x)
    //    {
    //        {
    //            if (value > 0)
    //            {
    //                this.y = value;

    //            }
    //            else if (value > 5)
    //            {
    //                this.x = 5;
    //            }
    //            this.x = 0;
    //        }
    //    }
    //    public int GetX()
    //    {
    //        return this.x;
    //    }

    //    private int y;

    //    public int Y
    //    {
    //        get {  return this.y; }
    //        set 
    //        {
    //            if (x > 0)
    //            {
    //                this.y = value;
    //            }
    //            else if (x > 5)
    //            {
    //                this.x = 5;
    //            }
    //            this.x = 0;
    //        }
    //    }
    //}


    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Point p1 = new Point();
    //        p1.SetX(10);
    //        Console.WriteLine(p1.GetX());

    //        p1.Y = 20;
    //        Console.WriteLine(p1.Y);
    //    }
    //}



    //abstract class Animal
    //{
    //    public string Name;
    //    public void Eat()
    //    {
    //        Console.WriteLine("Animal is eating");
    //    }
    //    public abstract void MakeSound();
    //}

    //class Dog : Animal
    //{
    //    public override void MakeSound()
    //    {
    //        Console.WriteLine("Woof!");
    //    }
    //}
    //    internal class Program
    //    {

    //        static void Main(string[] args)
    //        {
    //            Animal dog = new Dog();
    //            dog.MakeSound();

    //        }
    //    }
    //}







    //    interface IReload
    //    {
    //        void Reload();
    //    }
    //    abstract class Weapon
    //    {
    //        public abstract void Fire();
    //    }

    //    class Pistol : Weapon, IReload
    //    {
    //        public override void Fire()
    //        {
    //            Console.WriteLine("Pistol fired!");
    //        }
    //        public void Reload()
    //        {
    //            Console.WriteLine("Pistol reloaded!");
    //        }
    //    }

    //    class Sword : Weapon
    //    {
    //        public override void Fire()
    //        {
    //            Console.WriteLine("Sword swung!");
    //        }
    //    }



    //    class LaserGun : Weapon, IReload
    //    {
    //        public override void Fire()
    //        {
    //            Console.WriteLine("Laser gun fired!");
    //        }
    //        public void Reload()
    //        {
    //            Console.WriteLine("Laser gun recharged!");
    //        }
    //    }



    //    class Player
    //    {
    //        public void Shoot(Weapon weapon)
    //        {
    //            weapon.Fire();
    //        }
    //    }
    //    internal class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Player player = new Player();
    //            //Weapon pistol = new Pistol();
    //            //player.Shoot(pistol);

    //            Weapon[] inventory =
    //            {
    //                new Pistol(),
    //                new Sword(),
    //                new LaserGun(),
    //            };
    //            foreach (var w in inventory)
    //            {
    //                player.Shoot(w);

    //                Pistol pistol = new Pistol();
    //                pistol.Reload();

    //            }
    //        }
    //    }
    //}











    //abstract class Figure
    //{
    //    public abstract double CalculateArea();
    //}

    //class Circle : Figure
    //{
    //    private double Radius;

    //    public Circle(double radius)
    //    {
    //        this.Radius = radius;
    //    }

    //    public override double CalculateArea()
    //    {
    //        return Math.PI * Radius * Radius;
    //    }

    //}

    //class Rectangle : Figure
    //{
    //    private double Width;
    //    private double Height;
    //    public Rectangle(double width, double height)
    //    {
    //        this.Width = width;
    //        this.Height = height;
    //    }
    //    public override double CalculateArea()
    //    {
    //        return Width * Height;
    //    }
    //}



    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Figure circle = new Circle(5);
    //        Figure rectangle = new Rectangle(4, 6);

    //        Console.WriteLine("Площадь круга: " + circle.CalculateArea());
    //        Console.WriteLine("Площадь прямоугольника: " + rectangle.CalculateArea());
    //    }
    //}




    abstract class Transport
    {
        public string Name {  get; set; }
        public Transport(string name)
        {
            this.Name = name;
        }
        public abstract void Move();

    }

    interface IFuel
    {
        string GetFuelType();
    }
    
    class Car : Transport, IFuel
    {
        public Car(string name) : base(name) { }
       
        public override void Move()
        {
            Console.WriteLine($"{Name} едет по дороге");
        }
        public string GetFuelType()
        {
            return "Бензин";
        }
    }

    class CarElectric : Transport, IFuel
    {
        public CarElectric(string name) : base(name) { }
        public override void Move()
        {
            Console.WriteLine($"{Name} едет по дороге");
        }
        public string GetFuelType()
        {
            return "Электричество";
        }
    }

    class Bicycle : Transport
    {
        public Bicycle(string name) : base(name) { }
        public override void Move()
        {
            Console.WriteLine($"{Name} крутит педали по дороге");
        }
    }




    internal class Program
    {

        static void Main(string[] args)
        {
            Car car  = new Car("Toyota");
            Car car1 = new Car("Tesla");
            Bicycle bicycle = new Bicycle("BMX");

            car1.Move();
            Console.WriteLine("Тип топлива для автомобиля: " + car1.GetFuelType());
            Console.WriteLine("------------------------------");

            car.Move();
            Console.WriteLine("Тип топлива для автомобиля: " + car.GetFuelType());
            Console.WriteLine("------------------------------");

            bicycle.Move();


        }

    }
}
