#---------------------------------------------------
# 
# Selection Sort In python
#
#---------------------------------------------------
from __future__ import print_function


def selection_sort(collection):

    length = len(collection)
    for i in range(length):
        least = i
        for k in range(i + 1, length):
            if collection[k] < collection[least]:
                least = k
        collection[least], collection[i] = (
            collection[i], collection[least]
        )        
    return collection


if __name__ == '__main__':
    import sys
    unsorted = [15,11,20,14,12,13,17,16,18,19]
    print(selection_sort(unsorted))