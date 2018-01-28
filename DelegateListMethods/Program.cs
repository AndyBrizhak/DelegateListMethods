using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateListMethods
{
    delegate void OpStroke(ref int[] arr);

    public class ArrOperation
    {
        public static void WriteArray(ref int[] arr)
        {
            Console.WriteLine("Исходный массив: ");
            foreach (int i in arr)
                Console.Write("{0}\t", i);
            Console.WriteLine();
        }

        // Сортировка массива
        public static void IncSort(ref int[] arr)
        {
            int j, k;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                j = 0;
                do
                {
                    if (arr[j] > arr[j + 1])
                    {
                        k = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = k;
                    }
                    j++;
                }
                while (j < arr.Length - 1);
            }

         }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
