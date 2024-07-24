using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class TKNP_DeQui
{
    
    public static int BinarySearch(int[] array, int target, int left, int right)
    {
        if (left <= right)
        {

            int mid = left + (right - left) / 2;

            if (array[mid] == target)
            {
                return mid; 
            }

            if (array[mid] > target)
            {
                return BinarySearch(array, target, left, mid - 1);
            }

            else
            {
                return BinarySearch(array, target, mid + 1, right);
            }
        }

        return -1; 
    }

    static void Main()
    {

        int[] array = { 3, 9, 10, 27, 38, 43, 82 };
        int target = 38; 

      
        Console.WriteLine("Mang da sap xep: " + string.Join(", ", array));
        Console.WriteLine("Phan tu can tim: " + target);

        int index = BinarySearch(array, target, 0, array.Length - 1);

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
