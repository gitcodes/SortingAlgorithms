<h1> SelectionSort </h1>

The selection sort algorithm sorts an array by repeatedly finding the minimum element (considering ascending order) from unsorted part and putting it at the beginning. The algorithm maintains two subarrays in a given array.

1) The subarray which is already sorted.
2) Remaining subarray which is unsorted.

In every iteration of selection sort, the minimum element (considering ascending order) from the unsorted subarray is picked and moved to the sorted subarray.
<p>Example:</p>

<pre><code>
array[] = [15,11,20,14,12]

// Find the minimum element in arr[0...4]
// and place it at beginning
[11,15,20,14,12]

// Find the minimum element in arr[1...4]
// and place it at beginning of arr[1...4]
[11,12,20,14,15]

// Find the minimum element in arr[2...4]
// and place it at beginning of arr[2...4]
[11,12,14,20,15]

// Find the minimum element in arr[3...4]
// and place it at beginning of arr[3...4]
[11,12,14,15,20] 
</code></pre>
