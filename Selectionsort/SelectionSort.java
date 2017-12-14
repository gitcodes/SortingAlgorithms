class SelectionSort
{
    void sort(int array[])
    {
        int n = array.length;


        for (int i = 0; i < n-1; i++)
        {
            
            int min_idx = i;
            for (int j = i+1; j < n; j++)
                if (array[j] < array[min_idx])
                    min_idx = j;

            int temp = array[min_idx];
            array[min_idx] = array[i];
            array[i] = temp;
        }
    }

    void printArray(int arr[])
    {
        int n = arr.length;
        for (int i=0; i<n; ++i)
            System.out.print(arr[i]+" ");
        System.out.println();
    }

    public static void main(String args[])
    {
        SelectionSort ob = new SelectionSort();
        int arr[] = {15,11,20,14,12,13,17,16,18,19};
        ob.sort(arr);
        ob.printArray(arr);
    }
}