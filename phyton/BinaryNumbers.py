w = 524275


def binary(n):
    arr = bin(n)[2:]
    arr = arr.split('0')
    i = 0
    count = 0
    while i < len(arr):
        res = len(arr[i])
        if res > count:
            count = len(arr[i])
        i += 1
    return count


print(binary(w))