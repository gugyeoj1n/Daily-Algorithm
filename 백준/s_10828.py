import sys

base = []
for _ in range(int(sys.stdin.readline())) :
  cmd = sys.stdin.readline().split()
  if cmd[0] == "push" :
    base.append(int(cmd[1]))
  elif cmd[0] == "pop" :
    if not base : print(-1)
    else : print(base.pop())
  elif cmd[0] == "size" :
    print(len(base))
  elif cmd[0] == "empty" :
    print(1) if not base else print(0)
  else :
    print(base[-1]) if base else print(-1)