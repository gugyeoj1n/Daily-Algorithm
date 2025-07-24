import sys
input = sys.stdin.readline

N, M = map(int, input().split())
base = []

def dfs() :
  if len(base) == M :
    print(" ".join(map(str, base)))
    return
  for i in range(1, N + 1) :
    if i not in base :
      base.append(i)
      dfs()
      base.pop()

dfs()