using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class TemperatureSensor
    {

        public event Action<int> OnTemperatureTooHigh;

        public void SetTemperature(int temp)
        {
            Console.WriteLine($"Текущая температура: {temp}");

            if (temp > 30)
            {
                OnTemperatureTooHigh?.Invoke(temp);
            }
        }
    }

    internal class Program
    {
        static void Warning(int temp)
        {
            Console.WriteLine($"⚠️ Внимание! Температура слишком высокая: {temp}");
        }

        static void Alarm(int temp)
        {
            Console.WriteLine($"🚨 Сигнал тревоги! Перегрев: {temp}");
        }

        static void Log(int temp)
        {
            Console.WriteLine($"📄 Лог: зафиксирована температура {temp}");
        }

        static void Main(string[] args)
        {
            TemperatureSensor sensor = new TemperatureSensor();


            sensor.OnTemperatureTooHigh += Warning;
            sensor.OnTemperatureTooHigh += Alarm;
            sensor.OnTemperatureTooHigh += Log;


            sensor.SetTemperature(25);
            Console.WriteLine();

            sensor.SetTemperature(35);
            Console.WriteLine();

            sensor.SetTemperature(50);

            Console.ReadLine();
        }
    }
}
