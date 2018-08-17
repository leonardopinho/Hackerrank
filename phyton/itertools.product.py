from itertools import product

l1 = map(int, raw_input().split())
l2 = map(int, raw_input().split())

result = []
for item in list(product(l1, l2)):
    result.append(str(item))

print ' '.join(result)