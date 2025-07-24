import sys
from collections import deque
input = sys.stdin.readline
dx, dy = [0, 0, 1, -1], [1, -1, 0, 0]

def bfs(ground, x, y) :
  queue = deque()
  queue.append((x, y))
  ground[x][y] = 0

  while queue :
    X, Y = queue.popleft()
    for i in range(4) :
      nx, ny = X + dx[i], Y + dy[i]
      if (nx < N and ny< M) and (nx >= 0 and ny >= 0) :
        if ground[nx][ny] == 1 :
          ground[nx][ny] = 0
          queue.append((nx, ny))
      else : 
        continue
  return

for _ in range(int(input())) :
  N, M, K = map(int, input().split())
  cnt = 0
  ground = [[0] * M for _ in range(N)]

  for _ in range(K) :
    x, y = map(int, input().split())
    ground[x][y] = 1

  for a in range(N) :
    for b in range(M) :
      if ground[a][b] == 1 :
        bfs(ground, a, b)
        cnt += 1
  print(cnt)