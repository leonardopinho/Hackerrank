n = input()
l1 = set(map(int, input().split())) 
r = input()
l2 = set(map(int, input().split())) 
print(len(l1.symmetric_difference(l2)))