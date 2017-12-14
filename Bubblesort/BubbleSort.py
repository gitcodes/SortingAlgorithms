#---------------------------------------------------
# 
# Bubble Sort In python
#
#---------------------------------------------------
def bubble_sort(collection):
    length = len(collection)
    for i in range(length-1, -1, -1):#range(length-1, -1, -1)
        for j in range(i):#range(1, i)
            if collection[j] > collection[j+1]:
                collection[j], collection[j+1] = collection[j+1], collection[j]

    return collection


if __name__ == '__main__':
    import sys  
    unsorted = [15,11,20,14,12,13,17,16,18,19]
    print(bubble_sort(unsorted))
