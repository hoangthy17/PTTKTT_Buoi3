using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TKNP_KhongDeQui 
{
    public static int BinarySearch(int[] a, int target)
    {
        int left = 0;              
        int right = a.Length - 1; 

        while (left <= right)
        {
            
            int mid = left + (right - left) / 2;

            if (a[mid] == target)
            {
                return mid; 
            }

            if (a[mid] < target)
            {
                left = mid + 1;
            }
           
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }

    static void Main()
    {

        int[] a = { 3, 9, 10, 27, 38, 43, 82 };
        int target = 43;


        Console.WriteLine("Mang da sap xep: " + string.Join(", ", a));
        Console.WriteLine("Phan tu can tim: " + target);

        int index = BinarySearch(a, target);

        if (index != -1)
        {
            Console.WriteLine("Phan tu " + target + " duoc tim thay tai chi so: " + index);
        }
        else
        {
            Console.WriteLine("Phan tu " + target + " khong co trong mang.");
        }

        Console.ReadKey();
    }
}

