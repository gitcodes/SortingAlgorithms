/*
 * C# Program to Perform Bubble Sort
 */
using System;
namespace BubbleSorting
{
    class Sorting
    {
        static void Main(string[] args)
        {
            int[] array = {15,11,20,14,12,13,17,16,18,19};  
            int temp;            
            for (int j = 0; j <= a.Length - 1; j++)
            {
                for (int i = 0; i <= a.Length - j - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }
            Console.WriteLine("The Sorted Array :");
            foreach (int aray in a)                         
                Console.Write(aray + " ");
            Console.ReadLine();
        }
    }
}
