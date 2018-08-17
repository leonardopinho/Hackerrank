c1 = input()
l1 = set(map(int, [x for x in raw_input().replace(' ', ',').split(',')]))

c2 = input()
l2 = set(map(int, [x for x in raw_input().replace(' ', ',').split(',')]))

result = sorted(l1.difference(l2).union(l2.difference(l1)))

for x in result:
    print x