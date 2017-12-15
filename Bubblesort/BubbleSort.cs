/*

  Bubble Sort in C#

 */
 using System;
 
namespace BubbleSorting
{
    class Sorting
    {
        static void Main()
        {
            
            int[] array = { 15, 11, 20, 14, 12, 13, 17, 16, 18, 19 };
            int temp;
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - j - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            foreach (int element in array)
                Console.WriteLine(element + " ");
            

        }
    }
}
