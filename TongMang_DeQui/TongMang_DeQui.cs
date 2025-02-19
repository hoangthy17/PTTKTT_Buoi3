﻿using System;

namespace YourNamespace
{
    internal class TinhTong_DeQui
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
            if (l == r)
                return a[l];

            int mid = (l + r) / 2;
            int temp1 = Sum(a, l, mid);
            int temp2 = Sum(a, mid + 1, r);
            return temp1 + temp2;
        }

        static void Main()
        {
            int[] a;
            int n;
            NhapMang(out a, out n);
            Console.WriteLine("Mang da nhap:");
            XuatMang(a, n);

            int ketqua = Sum(a, 0, n - 1);
            Console.WriteLine("\nKet qua (de qui): "+ ketqua);
            Console.ReadLine();
        }
    }
}
