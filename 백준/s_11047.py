import sys
input = sys.stdin.readline

N, K = map(int, input().split())
base , cnt = [], 0
for _ in range(N) : base.append(int(input()))

for i in reversed(range(N)) :
  cnt += K // base[i]
  K %= base[i]
  if not K : break

print(cnt)