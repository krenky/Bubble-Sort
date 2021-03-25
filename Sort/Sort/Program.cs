using System;
using System.Diagnostics;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Bubble MassiveSort = new Bubble(20);
            Console.WriteLine(MassiveSort.GetMassiveString());
            //MassiveSort.BubbleSort();
            MassiveSort.QuickSort(MassiveSort.Massive1, 0, MassiveSort.Massive1.Length - 1);
            Console.WriteLine(MassiveSort.GetMassiveString());
            int MainMenu = 0;
            while (MainMenu < 10)
            {
                Stopwatch stopwatch = new Stopwatch();
                MainMenu =int.Parse(Console.ReadLine());
                Console.WriteLine("1: сортировка пузырьком\n" +
                    "2: быстрая сортровка\n" +
                    "3: заполнение массива");
                switch (MainMenu)
                {
                    case 1:
                        stopwatch.Start();
                        MassiveSort.BubbleSort();
                        stopwatch.Stop();
                        Console.WriteLine(MassiveSort.GetMassiveString());
                        Console.WriteLine("Потрачено тактов на выполнение: " + stopwatch.ElapsedTicks);
                        break;
                    case 2:
                        stopwatch.Start();
                        MassiveSort.QuickSort(MassiveSort.Massive1, 0, MassiveSort.Massive1.Length - 1);
                        stopwatch.Stop();
                        Console.WriteLine(MassiveSort.GetMassiveString());
                        Console.WriteLine("Потрачено тактов на выполнение: " + stopwatch.ElapsedTicks);
                        break;
                    case 3:
                        MassiveSort.Rand();
                        Console.WriteLine(MassiveSort.GetMassiveString());
                        break;
                }
            }
        }
    }
}
