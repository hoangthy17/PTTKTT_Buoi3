﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class TinhTong_KhongDeQui
{
    static void NhapMang(out int[] a, out int n)
    {
        Random rand = new Random();
        do
        {
            Console.Write("Nhap so phan tu cua mang: ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 0);

        a = new int[n];

        for (int i = 0; i < n; i++)
        {
            a[i] = rand.Next(1, 100);
        }
    }

    static void XuatMang(int[] a, int n)
    {
        for (int i = 0; i < n; i++)
        {
             Console.Write("Phan tu thu {0}:",i+1);
             a[i] = int.Parse(Console.ReadLine());
        }
       
    }

    static int Sum(int[] a, int l, int r)
    {
        int sum = 0;
        for (int i = l; i <= r; i++)
        {
            sum += a[i];
        }
        return sum;
    }

    static void Main()
    {
        int[] a;
        int n;
        NhapMang(out a, out n);
        Console.WriteLine("Mang da nhap:");
        XuatMang(a, n);

        int ketqua = Sum(a, 0, n - 1);
        Console.WriteLine("\nKet qua (khong de qui):" + ketqua);

        Console.ReadLine(); // Added to keep console window open in Visual Studio 2013
    }
}

