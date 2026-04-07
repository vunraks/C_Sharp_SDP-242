using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_4_DZ
{

    //#1
    //class ArrayTask
    //{
    //    private int[] A = new int[5];
    //    private double[,] B = new double[3, 4];
    //    private Random rand = new Random();

    //    public void FillA()
    //    {
    //        Console.WriteLine("Введите 5 чисел:");
    //        for (int i = 0; i < A.Length; i++)
    //            A[i] = int.Parse(Console.ReadLine());
    //    }

    //    public void FillB()
    //    {
    //        for (int i = 0; i < 3; i++)
    //            for (int j = 0; j < 4; j++)
    //                B[i, j] = rand.Next(1, 100);
    //    }

    //    public void Print()
    //    {
    //        Console.WriteLine("Массив A:");
    //        foreach (int x in A)
    //            Console.Write(x + " ");

    //        Console.WriteLine("\nМассив B:");
    //        for (int i = 0; i < 3; i++)
    //        {
    //            for (int j = 0; j < 4; j++)
    //                Console.Write(B[i, j] + "\t");
    //            Console.WriteLine();
    //        }
    //    }

    //    public void Calculate()
    //    {
    //        double max = A[0], min = A[0], sum = 0, product = 1;
    //        int sumEvenA = 0;
    //        double sumOddCols = 0;

    //        foreach (int x in A)
    //        {
    //            if (x > max) max = x;
    //            if (x < min) min = x;
    //            sum += x;
    //            product *= x;
    //            if (x % 2 == 0) sumEvenA += x;
    //        }

    //        for (int i = 0; i < 3; i++)
    //            for (int j = 0; j < 4; j++)
    //            {
    //                double val = B[i, j];
    //                if (val > max) max = val;
    //                if (val < min) min = val;
    //                sum += val;
    //                product *= val;

    //                if (j % 2 != 0)
    //                    sumOddCols += val;
    //            }

    //        Console.WriteLine($"Max: {max}, Min: {min}");
    //        Console.WriteLine($"Sum: {sum}, Product: {product}");
    //        Console.WriteLine($"Сумма четных A: {sumEvenA}");
    //        Console.WriteLine($"Сумма нечетных столбцов B: {sumOddCols}");
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ArrayTask task = new ArrayTask();

    //        task.FillA();
    //        task.FillB();
    //        task.Print();
    //        task.Calculate();
    //    }
    //}





    //#2
    //internal class Program
    //{
    //    class MatrixTask
    //    {
    //        private int[,] arr = new int[5, 5];
    //        private Random rand = new Random();

    //        public void Fill()
    //        {
    //            for (int i = 0; i < 5; i++)
    //            {
    //                for (int j = 0; j < 5; j++)
    //                {
    //                    arr[i, j] = rand.Next(-100, 101);
    //                    Console.Write(arr[i, j] + "\t");
    //                }
    //                Console.WriteLine();
    //            }
    //        }

    //        public void Calculate()
    //        {
    //            int min = 101, max = -101;
    //            int minIndex = 0, maxIndex = 0, k = 0;

    //            for (int i = 0; i < 5; i++)
    //                for (int j = 0; j < 5; j++)
    //                {
    //                    if (arr[i, j] < min)
    //                    {
    //                        min = arr[i, j];
    //                        minIndex = k;
    //                    }
    //                    if (arr[i, j] > max)
    //                    {
    //                        max = arr[i, j];
    //                        maxIndex = k;
    //                    }
    //                    k++;
    //                }

    //            int start = Math.Min(minIndex, maxIndex);
    //            int end = Math.Max(minIndex, maxIndex);

    //            int sum = 0;
    //            k = 0;

    //            for (int i = 0; i < 5; i++)
    //                for (int j = 0; j < 5; j++)
    //                {
    //                    if (k > start && k < end)
    //                        sum += arr[i, j];
    //                    k++;
    //                }

    //            Console.WriteLine($"Сумма между min и max: {sum}");
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        MatrixTask task = new MatrixTask();
    //        task.Fill();
    //        task.Calculate();
    //    }
    //}






    //#3
    //    internal class Program
    //    {
    //        class CaesarCipher
    //        {
    //            public string Encrypt(string text, int shift)
    //            {
    //                string result = "";

    //                foreach (char c in text)
    //                {
    //                    if (char.IsLetter(c))
    //                    {
    //                        char offset = char.IsUpper(c) ? 'A' : 'a';
    //                        result += (char)((c - offset + shift) % 26 + offset);
    //                    }
    //                    else
    //                        result += c;
    //                }
    //                return result;
    //            }

    //            public string Decrypt(string text, int shift)
    //            {
    //                return Encrypt(text, 26 - shift);
    //            }
    //        }


    //        static void Main(string[] args)
    //        {
    //            CaesarCipher cipher = new CaesarCipher();

    //            Console.Write("Введите текст: ");
    //            string text = Console.ReadLine();

    //            Console.Write("Сдвиг: ");
    //            int shift = int.Parse(Console.ReadLine());

    //            string enc = cipher.Encrypt(text, shift);
    //            Console.WriteLine("Зашифровано: " + enc);

    //            Console.WriteLine("Расшифровано: " + cipher.Decrypt(enc, shift));

    //        }
    //    }
    //}




    //#4
    //    internal class Program
    //    {
    //        class MatrixOperations
    //        {
    //            public void MultiplyByNumber(int[,] A, int num)
    //            {
    //                Console.WriteLine("Умножение на число:");
    //                for (int i = 0; i < 2; i++)
    //                {
    //                    for (int j = 0; j < 2; j++)
    //                        Console.Write(A[i, j] * num + " ");
    //                    Console.WriteLine();
    //                }
    //            }

    //            public void Add(int[,] A, int[,] B)
    //            {
    //                Console.WriteLine("Сложение:");
    //                for (int i = 0; i < 2; i++)
    //                {
    //                    for (int j = 0; j < 2; j++)
    //                        Console.Write(A[i, j] + B[i, j] + " ");
    //                    Console.WriteLine();
    //                }
    //            }

    //            public void Multiply(int[,] A, int[,] B)
    //            {
    //                int[,] C = new int[2, 2];

    //                for (int i = 0; i < 2; i++)
    //                    for (int j = 0; j < 2; j++)
    //                        for (int k = 0; k < 2; k++)
    //                            C[i, j] += A[i, k] * B[k, j];

    //                Console.WriteLine("Произведение:");
    //                for (int i = 0; i < 2; i++)
    //                {
    //                    for (int j = 0; j < 2; j++)
    //                        Console.Write(C[i, j] + " ");
    //                    Console.WriteLine();
    //                }
    //            }
    //        }

    //        static void Main(string[] args)
    //        {
    //            int[,] A = { { 1, 2 }, { 3, 4 } };
    //            int[,] B = { { 5, 6 }, { 7, 8 } };

    //            MatrixOperations m = new MatrixOperations();

    //            m.MultiplyByNumber(A, 2);
    //            m.Add(A, B);
    //            m.Multiply(A, B);
    //        }
    //    }
    //}




    //#5
    //    internal class Program
    //    {
    //        class Calculator
    //        {
    //            public int Calculate(string input)
    //            {
    //                int result = 0;
    //                int currentNumber = 0;
    //                char operation = '+';

    //                for (int i = 0; i < input.Length; i++)
    //                {
    //                    char c = input[i];

    //                    if (char.IsDigit(c))
    //                    {
    //                        currentNumber = currentNumber * 10 + (c - '0');
    //                    }

    //                    if (!char.IsDigit(c) || i == input.Length - 1)
    //                    {
    //                        if (operation == '+')
    //                            result += currentNumber;
    //                        else if (operation == '-')
    //                            result -= currentNumber;

    //                        operation = c;
    //                        currentNumber = 0;
    //                    }
    //                }

    //                return result;
    //            }
    //        }

    //        static void Main(string[] args)
    //        {
    //            Calculator calc = new Calculator();

    //            Console.Write("Введите выражение (например 10+5-3): ");
    //            string input = Console.ReadLine();

    //            int result = calc.Calculate(input);

    //            Console.WriteLine("Результат: " + result);
    //        }
    //    }
    //}




    //#6

    //    internal class Program
    //    {
    //        class TextFormatter
    //        {
    //            public string FixText(string text)
    //            {
    //                char[] arr = text.ToCharArray();
    //                bool newSentence = true;

    //                for (int i = 0; i < arr.Length; i++)
    //                {
    //                    if (newSentence && char.IsLetter(arr[i]))
    //                    {
    //                        arr[i] = char.ToUpper(arr[i]);
    //                        newSentence = false;
    //                    }

    //                    if (arr[i] == '.' || arr[i] == '!' || arr[i] == '?')
    //                        newSentence = true;
    //                }

    //                return new string(arr);
    //            }
    //        }

    //        static void Main(string[] args)
    //        {
    //            TextFormatter tf = new TextFormatter();

    //            Console.Write("Введите текст: ");
    //            string text = Console.ReadLine();

    //            Console.WriteLine(tf.FixText(text));
    //        }
    //    }
    //}



    //#7

    //    internal class Program
    //    {
    //        class TextFilter
    //        {
    //            public string Filter(string text, string badWord, out int count)
    //            {
    //                count = 0;
    //                string[] words = text.Split(' ');

    //                for (int i = 0; i < words.Length; i++)
    //                {
    //                    string clean = words[i].ToLower().Trim('.', ',', ':', ';');

    //                    if (clean == badWord.ToLower())
    //                    {
    //                        words[i] = new string('*', clean.Length);
    //                        count++;
    //                    }
    //                }

    //                return string.Join(" ", words);
    //            }
    //        }
    //        static void Main(string[] args)
    //        {
    //            TextFilter filter = new TextFilter();

    //            Console.WriteLine("Введите текст:");
    //            string text = Console.ReadLine();

    //            Console.Write("Запрещенное слово: ");
    //            string bad = Console.ReadLine();

    //            int count;
    //            string result = filter.Filter(text, bad, out count);

    //            Console.WriteLine(result);
    //            Console.WriteLine($"Замен: {count}");
    //        }
    //    }
}
