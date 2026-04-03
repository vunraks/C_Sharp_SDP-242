using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    //{
    //    class Student
    //    {
    //        class Car
    //        {
    //            private string driverName;
    //            private int currSpeed;
    //            private static int octaneNumber;

    //             static Car()
    //            {
    //                octaneNumber = 0;
    //            }

    //            public Car(string _driverName, int _currSpeed)
    //            {
    //                driverName = _driverName;
    //                currSpeed = _currSpeed;
    //            }
    //            public Car()
    //            {
    //                driverName = "";
    //                currSpeed = 10;
    //            }
    //            public Car(int _currSpeed, string _driverName)
    //            {
    //                driverName = _driverName;
    //                currSpeed = _currSpeed;
    //            }

    //            public void SetoctaneNumber(int _octaneNumber)
    //            {
    //                octaneNumber = _octaneNumber;
    //            }
    //            public static int GetOctaneNumber()
    //            {
    //                return octaneNumber;
    //            }

    //            public void PrintStatus()
    //            {
    //                Console.WriteLine($"{driverName} едет со скоростью {currSpeed} km/h");
    //            }
    //            public void SpeedUp(int delta)
    //            {
    //                currSpeed += delta;
    //            }
    //        }

    //            static void Main(string[] args)
    //            {
    //                //Car myCar = new Car("Вася", 60);
    //                ////myCar.PrintStatus();
    //                //for (int i = 0; i <= 10; i++)
    //                //{
    //                //    myCar.SpeedUp(10);
    //                //    myCar.PrintStatus();
    //                //}
    //                //Car.SetOctaneNumber(95);
    //                //Console.WriteLine(Car.GetOctaneNumber());

    //        }
    //        }
    //    }




    //internal class Program
    //{

    //    class Student
    //    {
    //        public string name;
    //        public static int count;

    //        static Student()
    //        {
    //            count = 0;
    //            Console.WriteLine("Статический конструктор вызван!");
    //        }
    //        public Student(string name)
    //        {
    //            this.name = name;
    //            count++;
    //            Console.WriteLine($"Обычный Конструктор вызван!");
    //        }

    //    }
    //    static void Main(string[] args)
    //    {
    //        Student s1 = new Student("Вася");
    //        Student s2 = new Student("Рома");
    //        Student s3 = new Student("Саня");
    //        Console.WriteLine($"Всего студентов: {Student.count}");
    //    }
    //}




    using System;

    class ATM
    {
        private double balance;
        private string owner;
        public static int totalAccounts = 0;
        public static double fee = 0.02;

        public ATM(string ownerName, double initialBalance)
        {
            owner = ownerName;
            balance = initialBalance;
            totalAccounts++;
        }

        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine(owner + " пополнил на: " + amount);
                return true;
            }
            Console.WriteLine(owner + ": нельзя пополнить отрицательное число");
            return false;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(owner + ": нельзя снять отрицательное число");
                return false;
            }

            double total = amount + amount * fee;

            if (total <= balance)
            {
                balance -= total;
                Console.WriteLine(owner + " снял " + amount + "$ (комиссия " + (amount * fee) + "$)");
                return true;
            }

            Console.WriteLine(owner + ": недостаточно средств");
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Владелец: " + owner);
            Console.WriteLine("Баланс: " + balance);
        }

        public static void ShowTotalAccounts()
        {
            Console.WriteLine("Всего счетов: " + totalAccounts);
        }
    }


    class Program
    {
        static void Main()
        {
            ATM a1 = new ATM("Alex", 1000);
            ATM a2 = new ATM("John", 500);
            ATM a3 = new ATM("Mike", 200);

            a1.ShowInfo();
            a2.ShowInfo();
            a3.ShowInfo();


            Console.WriteLine("\nПополняем счет Alex на 500:");
            if (a1.Deposit(500))
                Console.WriteLine("Пополнение выполнено.");
            else
                Console.WriteLine("Ошибка пополнения.");



            Console.WriteLine("\nСнимаем 300 со счета John:");
            if (a2.Withdraw(300))
                Console.WriteLine("Снятие выполнено.");
            else
                Console.WriteLine("Ошибка снятия.");



            Console.WriteLine("\nПробуем снять 500 со счета Mike:");
            if (a3.Withdraw(500))
                Console.WriteLine("Снятие выполнено.");
            else
                Console.WriteLine("Недостаточно средств.");



            Console.WriteLine("\n\n-------ВСЕ СЧЕТА-------");
            a1.ShowInfo();
            Console.WriteLine();
            a2.ShowInfo();
            Console.WriteLine();
            a3.ShowInfo();


            Console.WriteLine("\n----------------------");
            ATM.ShowTotalAccounts();
        }
    }
}