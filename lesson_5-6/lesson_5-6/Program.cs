using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5_6
{

    //#1
//    internal class Program
//    {
//        static void Increment(ref int x)
//        {
//            x++;
//        }
//        static void Decrement(ref int x)
//        {
//            x--;
//        }
//        static void Main(string[] args)
//        {
//            int a = 10;
//            Console.WriteLine("+1");
//            Increment(ref a);
//            Console.WriteLine(a);
//            Console.WriteLine("-1");
//            Decrement(ref a);
//            Console.WriteLine(a);
//        }
//    }
//}


//#2
//internal class Program
//{
//    static void SetMin(int a, int b, out int min)
//    {
//        if (a < b)
//            min = a;
//        else
//            min = b;
//    }
//    static void Main(string[] args)
//    {   
//        int x = 5, y = 3;
//        int min;

//        SetMin(x, y, out min);
//        Console.WriteLine("Наименьшее число: ");
//        Console.WriteLine(min);
//    }
//}

//internal class Program
//{
//    static bool TryParse(string str, out int number)
//    {
//        number = 0;

//        foreach (char c in str)
//        {
//            if (c < '0' || c > '9')
//                return false;
//        }

//        if (str.Length == 0)
//            return false;

//        number = int.Parse(str);
//        return true;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        string input = Console.ReadLine();

//        if (TryParse(input, out int result))
//        {
//            Console.WriteLine("Число: " + result);
//        }
//        else
//        {
//            Console.WriteLine("Это не число");
//        }
//    }
//}
