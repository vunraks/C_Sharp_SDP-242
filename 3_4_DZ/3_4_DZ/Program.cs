using System;

class Program
{
    static void Main()
    {
        // Выбираешь что запускать:
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
        Task7();
    }

    static void Task1()
    {
        Console.WriteLine("=== Task 1 ===");

        int[] A = new int[5];
        double[,] B = new double[3, 4];
        Random rand = new Random();

        for (int i = 0; i < A.Length; i++)
            A[i] = rand.Next(1, 10);

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 4; j++)
                B[i, j] = rand.Next(1, 10);

        foreach (int x in A)
            Console.Write(x + " ");
        Console.WriteLine();

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
                Console.Write(B[i, j] + " ");
            Console.WriteLine();

        }
        Console.WriteLine();
    }

    static void Task2()
    {
        Console.WriteLine("=== Task 2 ===");

        int[,] arr = new int[5, 5];
        Random rand = new Random();

        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
                arr[i, j] = rand.Next(-100, 100);

        int sum = 0;
        foreach (int x in arr)
            sum += x;

        Console.WriteLine("Сумма: " + sum);
        Console.WriteLine();
    }


    static void Task3()
    {
        Console.WriteLine("=== Task 3 ===");

        string text = "abc";
        int shift = 3;
        string result = "";

        foreach (char c in text)
        {
            char newChar = (char)((c - 'a' + shift) % 26 + 'a');
            result += newChar;
        }

        Console.WriteLine(result);
        Console.WriteLine();
    }

    static void Task4()
    {
        Console.WriteLine("=== Task 4 ===");

        int[,] A = { { 1, 2 }, { 3, 4 } };
        int[,] B = { { 5, 6 }, { 7, 8 } };

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
                Console.Write(A[i, j] + B[i, j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Task5()
    {
        Console.WriteLine("=== Task 5 ===");

        string input = "10+5-3";
        int result = 0;
        int num = 0;
        char op = '+';

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];

            if (char.IsDigit(c))
                num = num * 10 + (c - '0');

            if (!char.IsDigit(c) || i == input.Length - 1)
            {
                if (op == '+') result += num;
                else result -= num;

                op = c;
                num = 0;
            }

        }

        Console.WriteLine(result);
        Console.WriteLine();
    }

    static void Task6()
    {
        Console.WriteLine("=== Task 6 ===");

        string text = "hello. how are you.";
        char[] arr = text.ToCharArray();

        bool start = true;

        for (int i = 0; i < arr.Length; i++)
        {
            if (start && char.IsLetter(arr[i]))
            {
                arr[i] = char.ToUpper(arr[i]);
                start = false;
            }

            if (arr[i] == '.')
                start = true;
        }

        Console.WriteLine(new string(arr));
        Console.WriteLine();
    }

    static void Task7()
    {
        Console.WriteLine("=== Task 7 ===");

        string text = "to die or not to die";
        string bad = "die";

        string[] words = text.Split(' ');
        int count = 0;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == bad)
            {
                words[i] = "***";
                count++;
            }
        }

        Console.WriteLine(string.Join(" ", words));
        Console.WriteLine("Замен: " + count);
    }
}