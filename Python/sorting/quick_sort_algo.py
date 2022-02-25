
def quick_sort(sequence):
    if len(sequence) <= 1:
        return sequence
    else:
        pivot = sequence.pop()

        greater_value = list()
        lesser_value = list()

        for item in sequence:
            if item > pivot:
                greater_value.append(item)
                print(f'item: {item} > pivot: {pivot}')
            else:
                lesser_value.append(item)
                print(f'item: {item} < pivot: {pivot}')
        
        return quick_sort(lesser_value) + [pivot] + quick_sort(greater_value)


sequence = [9,8,7,6,5,4,3,2,1]
result = quick_sort(sequence)
print(result)

# The Quick Sort Algorithm
# First you need to get the last item of a list
# You can apply recursion

