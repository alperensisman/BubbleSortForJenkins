using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortForJenkins
{
    class BubbleSort
    {

        public static void bubbleSort(ref int[] dizi)
        {
            int n = dizi.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (dizi[j] > dizi[j + 1])
                    {
                        int temp = dizi[j];
                        dizi[j] = dizi[j + 1];
                        dizi[j + 1] = temp;
                    }
                }
            }
        }

    }

    class Program
    {
        public static int[] randomDizi(int countArr)
        {
            int[] dizi = new int[countArr];
            Random rnd = new Random();
            for (int i = 0; i < countArr; i++) dizi[i] = rnd.Next(0, countArr + 1);
            return dizi;
        }

        public static void printDizi(string tag, int[] dizi)
        {
            Console.WriteLine("\n" + tag + "\n");
            for (int i = 0; i < dizi.Length; i++) Console.Write(dizi[i].ToString() + ",");
            Console.WriteLine(new string('_', 100));
        }

        static void Main(string[] args)
        {
            int uzunluk = 10000;
            int[] dizi = randomDizi(uzunluk);
            Stopwatch stp = new Stopwatch();
            stp.Start();
            BubbleSort.bubbleSort(ref dizi);
            stp.Stop();
            Console.WriteLine("Geçen Süre: " + stp.Elapsed);
        }
    }
}
