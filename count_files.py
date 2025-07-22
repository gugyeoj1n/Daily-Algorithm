import os

EXCLUDE_FILE = os.path.basename(__file__)

extensions = ['.cpp', '.py', '.cs']
counts = {ext: 0 for ext in extensions}

for root, dirs, files in os.walk('.'):
    for file in files:
        if file == EXCLUDE_FILE:
            continue

        for ext in extensions:
            if file.endswith(ext):
                counts[ext] += 1

total_count = sum(counts.values())

with open('README.md', 'w', encoding='utf-8') as f:
    f.write('### Daily Algorithm\n\n')
    f.write(f'    지금까지 {total_count}개의 문제를 풀었습니다.\n')
