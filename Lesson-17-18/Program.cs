using System;

namespace Lesson_17_18
{
    enum GameState { Menu, Playing, Paused, GameOver }

    class Game
    {
        public GameState State = GameState.Menu;

        public void StartGame()
        {
            if (State != GameState.GameOver)
                State = GameState.Playing;
            else
                Console.WriteLine("Игра завершена");
        }

        public void PauseGame()
        {
            if (State == GameState.Playing)
                State = GameState.Paused;
            else
                Console.WriteLine("Нельзя на паузу");
        }

        public void ResumeGame()
        {
            if (State == GameState.Paused)
                State = GameState.Playing;
            else
                Console.WriteLine("Не на паузе");
        }

        public void EndGame() => State = GameState.GameOver;

        public void ShowState() => Console.WriteLine(State);
    }

    enum AccessLevel { Guest, User, Moderator, Admin }

    class Account
    {
        public string Name;
        public AccessLevel Level;

        public Account(string n, AccessLevel l)
        {
            Name = n;
            Level = l;
        }

        public bool CanAccess(string action)
        {
            bool r = false;

            if (action == "read") r = true;
            if (action == "write") r = Level >= AccessLevel.User;
            if (action == "delete") r = Level >= AccessLevel.Moderator;
            if (action == "full") r = Level == AccessLevel.Admin;

            Console.WriteLine($"{action}: {r}");
            return r;
        }
    }

    enum PaymentStatus { Pending, Completed, Failed, Refunded }

    class Payment
    {
        public int Id;
        public double Amount;
        public PaymentStatus Status;

        public Payment(int id, double amount)
        {
            Id = id;
            Amount = amount;
            Status = PaymentStatus.Pending;
        }

        public void Pay()
        {
            if (Status != PaymentStatus.Completed)
                Status = PaymentStatus.Completed;
            else
                Console.WriteLine("Уже оплачено");
        }

        public void Fail() => Status = PaymentStatus.Failed;

        public void Refund()
        {
            if (Status == PaymentStatus.Completed)
                Status = PaymentStatus.Refunded;
            else
                Console.WriteLine("Нельзя вернуть");
        }

        public void Show() => Console.WriteLine($"{Id} {Amount} {Status}");
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n1-Game 2-Account 3-Payment 0-Exit");
                string c = Console.ReadLine();

                if (c == "1") GameMenu();
                if (c == "2") AccountMenu();
                if (c == "3") PaymentMenu();
                if (c == "0") break;
            }
        }

        static void GameMenu()
        {
            Game g = new Game();

            while (true)
            {
                Console.WriteLine("\n1.Show 2.Start 3.Pause 4.Resume 5.End 0.Back");
                string c = Console.ReadLine();

                if (c == "1") g.ShowState();
                if (c == "2") g.StartGame();
                if (c == "3") g.PauseGame();
                if (c == "4") g.ResumeGame();
                if (c == "5") g.EndGame();
                if (c == "0") break;
            }
        }

        static void AccountMenu()
        {
            Account acc = new Account("User", AccessLevel.User);

            while (true)
            {
                Console.WriteLine("\nread/write/delete/full или 0");
                string a = Console.ReadLine();

                if (a == "0") break;
                acc.CanAccess(a);
            }
        }

        static void PaymentMenu()
        {
            Payment p = new Payment(1, 1000);

            while (true)
            {
                Console.WriteLine("\n1.Show 2.Pay 3.Fail 4.Refund 0.Back");
                string c = Console.ReadLine();

                if (c == "1") p.Show();
                if (c == "2") p.Pay();
                if (c == "3") p.Fail();
                if (c == "4") p.Refund();
                if (c == "0") break;
            }
        }
    }
}