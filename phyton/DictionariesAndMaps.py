#!/bin/python3

n = int(input().strip())

phoneNumber = {}

# get phone list
for i in range(0, n):
    line = str(input().strip())
    item = line.split(' ')
    phoneNumber[item[0]] = item[1]

# get names list
for i in range(0, n):
    line = str(input().strip())
    try:
        print('{0}={1}'.format(line, phoneNumber[line]))
    except KeyError:
        print('Not found')
