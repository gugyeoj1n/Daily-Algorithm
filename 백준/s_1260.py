import sys
from collections import deque
input = sys.stdin.readline

def dfs(n) :
  dfs_res.append(n)
  check[n] = True
  for i in graph[n] :
    if not check[i] :
      dfs(i)

def bfs(n) :
  check[n] = True
  queue = deque([n])
  while queue :
    v = queue.popleft()
    bfs_res.append(v)
    for i in graph[v] :
      if not check[i] :
        queue.append(i)
        check[i] = True

N, M, V = map(int, input().split())
graph, check = [[] for _ in range(N + 1)], [False for _ in range(N + 1)]
dfs_res, bfs_res = [], []
for _ in range(M) :
  x, y = map(int, input().split())
  graph[x].append(y)
  graph[y].append(x)
for i in range(N + 1) :
  graph[i].sort()
  
dfs(V)
for i in dfs_res :
  print(i, end=" ")

check = [False for _ in range(N + 1)]
print()

bfs(V)
for i in bfs_res :
  print(i, end=" ")