import sys
input = sys.stdin.readline

base, check = {}, []

for t in range(int(input())) :
    base[t + 1] = set()

for i in range(int(input())) :
    x, y = map(int, input().split())
    base[x].add(y)
    base[y].add(x)   
    
def dfs(start, dic) :
    for i in dic[start] :
        if i not in check :
            check.append(i)
            dfs(i, dic)

dfs(1, base)
print(len(check) - 1)