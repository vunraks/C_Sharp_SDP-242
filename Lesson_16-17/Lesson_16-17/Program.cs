using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16_17
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine((ConsoleKey)9);
    //        while (true)
    //        {
    //            ConsoleKey key = Console.ReadKey().Key;

    //            int keyCode = (int)key;

    //            Console.WriteLine($"Enum {key}, KeyCode {keyCode}");
    //            if (key == ConsoleKey.Enter)
    //            {
    //                Console.WriteLine("Нажат Enter");
    //            }

    //        }
    //    }
    //}




    //internal class Program
    //{
    //enum DayOfWeek
    //{
    //    Monday = 1,
    //    Tuesday = 2,
    //    Wednesday = 3,
    //    Thursday = 4,
    //    Friday = 5,
    //    Saturday = 6,
    //    Sunday = 7,
    //}

    //static DayOfWeek GetNextDay(DayOfWeek dayOfWeek)
    //{
    //    if (dayOfWeek == DayOfWeek.Sunday)
    //    {
    //        return DayOfWeek.Monday;
    //    }
    //    return dayOfWeek + 1;

    //}
    //    static void Main(string[] args)
    //    {
    //        DayOfWeek day = DayOfWeek.Monday;
    //    Console.WriteLine(day);
    //    Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));

    //    DayOfWeek nextDay = GetNextDay(day);
    //    Console.WriteLine(nextDay);
    //    Console.WriteLine((int)nextDay);
    //    Console.Write("Введите число от 1 до 7:  ");
    //    int number = int.Parse(Console.ReadLine());
    //    Console.WriteLine((DayOfWeek)8);

    //        for (int i = 1; i <= (int)DayOfWeek.Sunday; i++)
    //        {
    //            Console.WriteLine((DayOfWeek)i);
    //        }
    //        Console.WriteLine("Все дни недели:");
    //        foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
    //        {
    //            Console.WriteLine(day);
    //        }
    //    }
    //}





    //internal class Program
    //{
    //    enum UserRole
    //    {
    //        Admin = 1,
    //        User = 2,
    //        Guest = 3
    //    }
    //    static bool IsAdmin(UserRole role)
    //    {
    //        return role == UserRole.Admin;  
    //    }
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Выберите роль:");
    //        Console.WriteLine("1 - Admin");
    //        Console.WriteLine("2 - User");
    //        Console.WriteLine("3 - Guest");

    //        int choise = int.Parse(Console.ReadLine());

    //        UserRole role = (UserRole)choise;
    //        Console.WriteLine($"Вы выбрали: {role}");

    //        if (IsAdmin(role))
    //        {
    //            Console.WriteLine("Полный доступ");

    //        }
    //        else
    //        {
    //            Console.WriteLine("Ограниченный доступ");

    //        }

    //    }
    //}





    enum OrderStatus
    {
        Created,
        Paid,
        Shipped,
        Delivered,
        Canceled,
        Returned
    }
    class Order
    {
        public int Id;
        public string productName;
        public OrderStatus Status;

        public Order(int id, string productName, OrderStatus status)
        {
            this.Id = id;
            this.productName = productName;
            this.Status = status;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Заказ {Id}: {productName}, Статус: {Status}");
        }
        public void NextStatus()
        {
            if (Status == OrderStatus.Created)
            {
                Status = OrderStatus.Paid;
            }
            else if (Status == OrderStatus.Paid)
            {
                Status = OrderStatus.Shipped;
            }
            else if (Status == OrderStatus.Shipped)
            {
                Status = OrderStatus.Delivered;
            }
            else
                Console.WriteLine("Заказ уже доставлен или отменен");

        }
        public void Cancel()
        {
            if (Status == OrderStatus.Delivered)
            {
                Console.WriteLine("Невозможно отменить доставленный заказ");

            }
            else Status = OrderStatus.Canceled;


}
        }
        internal class Program
        {

            static void Main(string[] args)
            {
                Order order1 = new Order(1, "Телефон", OrderStatus.Created);
                order1.ShowInfo();

                order1.NextStatus();    
                order1.ShowInfo();

                order1.Status = OrderStatus.Delivered;
            order1.Cancel();
            order1.ShowInfo();
        }
        }
    }
