using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void QuickSort(int[] a, int l, int r)
    {
        if (l < r)
        {

            int pivotIndex = Partition(a, l, r);

            QuickSort(a, l, pivotIndex - 1);
            QuickSort(a, pivotIndex + 1, r);
        }
    }

    static int Partition(int[] a, int l, int r)
    {
        int pivot = a[r]; 
        int i = l - 1;

        for (int j = l; j < r; j++)
        {
            if (a[j] >= pivot)
            {
                i++;

                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
        }


        int temp1 = a[i + 1];
        a[i + 1] = a[r];
        a[r] = temp1;

        return i + 1; 
    }


    static void PrintArray(int[] a)
    {
        foreach (var number in a)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.Title = "Quick Sort";
        int[] numbers = new int[] { 10, 3, 1, 7, 9, 2 };

        Console.WriteLine("Truoc khi sap xep:");
        PrintArray(numbers);

        QuickSort(numbers, 0, numbers.Length - 1);

        Console.WriteLine("\nSau khi sap xep:");
        PrintArray(numbers);

        Console.ReadKey();
    }
}
