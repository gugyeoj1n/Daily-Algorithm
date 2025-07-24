import sys
input = sys.stdin.readline
queue = []
for _ in range(int(input())) :
  command = input().split()
  if command[0] == "pop" :
    try : print(queue.pop(0))
    except : print(-1)
  elif command[0] == "size" :
    print(len(queue))
  elif command[0] == "empty" :
    print(1) if len(queue) == 0 else print(0)
  elif command[0] == "front" :
    try : print(queue[0])
    except : print(-1)
  elif command[0] == "back" :
    try : print(queue[len(queue) - 1])
    except : print(-1)
  else :
    queue.append(command[1])