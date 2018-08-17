# 'A set is an unordered collection of elements without duplicate entries.'

l = input()
data = set(raw_input().replace(' ', ',').split(','))
print sum(map(int, [x for x in data])) / float(len(data))