/*

  Selection Sort in C#

 */
 using System;
 
namespace BubbleSorting
{
    class Sorting
    {
         static void Main()
        {
            
            int[] array = { 15, 11, 20, 14, 12, 13, 17, 16, 18, 19 };
            int temp,minindex;
            for (int j = 0; j < array.Length - 1; j++)
            {
               minindex = j ;
                for (int i = j+1; i < array.Length ; i++)
                {
                    if (array[i] < array[minindex])
                      minindex = i;
                }            
                        temp = array[j];
                        array[j] = array[minindex];
                        array[minindex] = temp;                
            }
            foreach (int element in array)
                Console.WriteLine(element + " ");
           
            

        }
    }
}
