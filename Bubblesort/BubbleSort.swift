var array = [15,11,20,14,12,13,17,16,18,19]
var sortedArray = Array(array)
var sortedAboveIndex = array.count 

for i in 0 ..< sortedAboveIndex-1 {

	for j in 0 ..< sortedAboveIndex-i-1 {
    
		if (sortedArray[j] > sortedArray[j+1]) {
        
			sortedArray.swapAt(j, j+1)        
        }
    }

}

print(sortedArray)