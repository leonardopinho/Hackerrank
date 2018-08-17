len = int(input())
data = input().split(' ')
list = []

for i in range(len):
    list.append(int(data[i])) 

t = tuple(list)

print(hash(t))