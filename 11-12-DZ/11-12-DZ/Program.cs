using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_12_DZ
{
    using System;

    // ================= 1. ABSTRACT CLASS =================
    abstract class Transport
    {
        public string Name { get; set; }

        public Transport(string name)
        {
            Name = name;
        }

        public abstract void Move();
    }

    // ================= 2. INTERFACE =================
    interface IFlyable
    {
        void Fly();
    }

    // ================= 3. INTERFACE =================
    interface IDriveable
    {
        void Drive();
    }

    // ================= 4. CAR =================
    class Car : Transport, IDriveable
    {
        public Car(string name) : base(name) { }

        public override void Move()
        {
            Console.WriteLine("Машина едет");
        }

        public void Drive()
        {
            Console.WriteLine("Машина движется по дороге");
        }
    }

    // ================= 5. PLANE =================
    class Plane : Transport, IFlyable
    {
        public Plane(string name) : base(name) { }

        public override void Move()
        {
            Console.WriteLine("Самолет движется");
        }

        public void Fly()
        {
            Console.WriteLine("Самолет летит");
        }
    }

    // ================= 6. AMPHIBIOUS CAR =================
    class AmphibiousCar : Transport, IDriveable
    {
        public AmphibiousCar(string name) : base(name) { }

        public override void Move()
        {
            Console.WriteLine("Амфибия едет и плывет");
        }

        public void Drive()
        {
            Console.WriteLine("Амфибия едет по дороге");
        }
    }

    // ================= MAIN =================
    class Program
    {
        static void Main()
        {
            Car car = new Car("BMW");
            Plane plane = new Plane("Boeing");
            AmphibiousCar amphib = new AmphibiousCar("AmphiCar");

            car.Move();
            car.Drive();
            Console.WriteLine();

            plane.Move();
            plane.Fly();
            Console.WriteLine();

            amphib.Move();
            amphib.Drive();
        }
    }
}
