using System;

namespace Copy_a_Section_of_One_Array_to_Another///In this C# program, we are reading the size of the array using ‘n’ variable. Using for loop we are entering the coefficient element values of an array using a[] variable.///
{
    class Program
    {
        static void Main(string[] args)////Enter the size of the target array the section of the first array that has to be copied using ‘m’ and ‘size’ variables respectively. Here a section of array is copied using the array.copy() with the source array, target array and the size.///
        {
            int n, m, size;
            Console.WriteLine("Enter the size of the Array : ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter the Elements of the First Array :");
            for (int i = 0; i < n; i++)///////Using foreach loop print the new array with the specified section of elements in the first array. The foreach statement is used to iterate through the collection to get the information that you want, but cannot be used to add or remove items from the source collection to avoid unpredictable side effects.///
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the Size of the Target Array : ");
            m = Convert.ToInt32(Console.ReadLine());
            int[] target = new int[m];
            Console.WriteLine("Enter the section of the First Array " +
                              "that has to be Copied :");
            size = Convert.ToInt32(Console.ReadLine());
            Array.Copy(a, 0, target, 0, size);
            Console.WriteLine("New Array With The Specified Section of Elements " +
                              "in the First Array");
            foreach (int value in target)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
///Output: Enter the size of the Array : 5
///Enter the Elements of the First Array : 
///1
///2
///3
///4
///5
///Enter the Size of the Target Array :
///5
///Enter the section of the First Array that has to be Copied : 1
///New Array With The Specified Section of Elements in the First Array :
///1
///0
///0
///0
///0
///0
