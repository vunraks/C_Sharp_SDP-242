using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_23_24
{
    //class BankAccount
    //{
    //    public string Owner;
    //    public decimal Balance;

    //    public event Action<string> OnTransaction;

    //    public BankAccount(string owner, decimal balance)
    //    {
    //        this.Owner = owner;
    //        this.Balance = balance;
    //    }

    //    public void Deposit(decimal amount)
    //    {
    //        if (amount <= 0)
    //        {
    //            OnTransaction?.Invoke($"{Owner}: некорректная сумма пополнения!");
    //            return;
    //        }
    //        Balance += amount;
    //        OnTransaction?.Invoke($"{Owner}: пополнение на {amount}$");
    //    }

    //    public void Withdraw(decimal amount)
    //    {
    //        if (amount <= 0)
    //        {
    //            OnTransaction?.Invoke($"{Owner}: некорректная сумма пополнения!");
    //            return;
    //        }
    //        if (amount > Balance)
    //        {
    //            OnTransaction?.Invoke($"{Owner}: недостаточно средств на балансе!");
    //            return;
    //        }

    //        Balance -= amount;
    //        OnTransaction?.Invoke($"{Owner}: успешное снятие {amount}$");
    //    }

    //    public static void Transfer(BankAccount from, BankAccount to, decimal amount)
    //    {
    //        if (amount <= 0)
    //        {
    //            from.OnTransaction?.Invoke($"{from.Owner}: некорректная сумма пополнения!");
    //            return;
    //        }
    //        if (amount > from.Balance)
    //        {
    //            from.OnTransaction?.Invoke($"{from.Owner}: недостаточно средств на балансе!");
    //            return;
    //        }
    //        from.Balance -= amount;
    //        to.Balance += amount;

    //        from.OnTransaction?.Invoke($"Перевод {amount} -> {to.Owner}");
    //        to.OnTransaction?.Invoke($"Получено {amount} от {from.Owner}");
    //    }

    //    public static BankAccount operator +(BankAccount bankAccount, decimal amount)
    //    {
    //        bankAccount.Deposit(amount);
    //        return bankAccount;
    //    }
    //    public static BankAccount operator -(BankAccount bankAccount, decimal amount)
    //    {
    //        bankAccount.Withdraw(amount);
    //        return bankAccount;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Owner}: {Balance}$";
    //    }
    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        BankAccount account1 = new BankAccount("Alice™", 1000);
    //        BankAccount account2 = new BankAccount("Bob™", 500);

    //        account1.OnTransaction += message => Console.WriteLine($"[ACC1]" + message);
    //        account2.OnTransaction += message => Console.WriteLine($"[ACC2] " + message);

    //        Console.WriteLine("-------Начальные значения-------");
    //        Console.WriteLine(account1);
    //        Console.WriteLine(account2);

    //        Console.WriteLine("-------Операции-------");
    //        account1 += 200;
    //        account2 -= 100;

    //        BankAccount.Transfer(account1, account2, 400);

    //        account1 -= 2000;
    //    }
    //}





    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        double a = 10;
    //        int b = 15;

    //        Console.WriteLine($"a: {a}\t b: {b}");
    //        Swap(ref a, ref b);
    //        Console.WriteLine($"a: {a}\t b: {b}");
    //    }
    //    static void Swap(ref double a, ref int b)
    //    {
    //        double temp = a;
    //        a = b;
    //        b = (int)temp;
    //    }
    //}


    internal class Program
    {
        static void PrintArray<T>(in T[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            }
            static void Main(string[] args)
           {
            int[] numbers = { 1, 2, 3 };
            string[] words = { "Hello", "World" };

            PrintArray(in numbers);
            PrintArray(in words);
           }

    }
}