/*

Selection Sort in Swift 4.0.2

*/

var array = [15,11,20,14,12,13,17,16,18,19]
var sortedArray = Array(array)
var sortedAboveIndex = array.count 

for i in 0 ..< sortedAboveIndex - 1 {
	var minindex = i
	for j in (i + 1) ..< sortedAboveIndex {
    
		if (sortedArray[j] < sortedArray[minindex]) {
         minindex = j
		}
			     
    }
sortedArray.swapAt(minindex,i)
}

print(sortedArray)