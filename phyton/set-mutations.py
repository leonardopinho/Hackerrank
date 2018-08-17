n = input()
l = set(map(int, raw_input().split()))

c = input()
for i in range(c):
    cmd = raw_input().split()
    c_l = set(map(int, raw_input().split()))
    eval('l.{0}({1})'.format(cmd[0], c_l))

print sum(l)