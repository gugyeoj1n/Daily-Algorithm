import sys
input = sys.stdin.readline
from itertools import combinations

base = ["a", "e", "i", "o", "u"]

L, C = map(int, input().split())
alps = sorted(input().strip().split())

for password in list(combinations(alps, L)) :
  a, b = 0, 0
  for i in password :
    if i in base :
      a += 1
    else : 
      b += 1
  if a > 0 and b > 1 :
    print("".join(list(map("".join, password))))