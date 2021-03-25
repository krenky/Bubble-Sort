using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Bubble
    {
        int[] Massive;
        public Bubble(int length)
        {
            Massive1 = new int[length];
            Random rand = new Random();
            for (int i = 0; i < Massive1.Length; i++)
                Massive1[i] = rand.Next(0, 20);
        }

        public int[] Massive1 { get => Massive; set => Massive = value; }

        public string GetMassiveString()// получение массива в текстовой строке
        {
            string MassiveString = "";
            foreach(int i in Massive1)
            {
                MassiveString = MassiveString + "||" + i;
            }
            return MassiveString;
        }
        public void Rand()
        {
            Random rand = new Random();
            for (int i = 0; i < Massive1.Length; i++)
                Massive1[i] = rand.Next(0, 20);
        }
        public void BubbleSort()//сортировка пузырьком
        {
            int Posrednik;
            for(int i = 0; i < Massive1.Length; i++)
            {
                for(int j = 0; j < Massive1.Length - i - 1; j++)
                {
                    if (Massive1[j] > Massive1[j + 1])//условие при котором эдементы меняютчя местами
                    {
                        Posrednik = Massive1[j];
                        Massive1[j] = Massive1[j + 1];
                        Massive1[j + 1] = Posrednik;
                    }
                }
            }
        }
       
        public void Change(int First, int End)
        {
            int Posrednik = Massive1[First];
            Massive1[First] = Massive1[End];
            Massive1[End] = Posrednik;
        }
        
        public void QuickSort(int[] arr, int first, int last)
        {
            int p = arr[(last - first) / 2 + first];
            int temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (arr[i] < p && i <= last) ++i;
                while (arr[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) QuickSort(arr, first, j);
            if (i < last) QuickSort(arr, i, last);
        }
    }
}
