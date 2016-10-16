
len = int(input())

list = []

for i in range(len):
    data = input().split(' ')
    
    if data[0] == 'insert':
        list.insert(int(data[1]), int(data[2]))
    elif data[0] == 'print':
        print(list)
    elif data[0] == 'remove':
        list.remove(int(data[1]))
    elif data[0] == 'append':
        list.append(int(data[1]))
    elif data[0] == 'sort':
        list.sort()
    elif data[0] == 'pop':
        list.pop()
    elif data[0] == 'reverse':
        list.reverse()