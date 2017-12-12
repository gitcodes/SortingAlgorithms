var array = [15,11,20,14,12,13,17,16,18,19];
 
function bubbleSort(array)
{
   
    for(var j=0; j < array.length-1 ; j++) 
    {
        
        for (var i=0; i < array.length-j-1; i++)
        {
            if (array[i] > array[i+1])
            {
                var temp = array[i];
                array[i] = array[i+1];
                array[i+1] = temp;
            }
        }
    } 
}
 
bubbleSort(array);
console.log(array);