import os

EXCLUDE_FILE = os.path.basename(__file__)

extensions = ['.cpp', '.py', '.cs', 'cc', 'js']
counts = {ext: 0 for ext in extensions}

for root, dirs, files in os.walk('.'):
    for file in files:
        if file == EXCLUDE_FILE:
            continue

        for ext in extensions:
            if file.endswith(ext):
                counts[ext] += 1

total_count = sum(counts.values())

now = datetime.now()
weekdays = ["월", "화", "수", "목", "금", "토", "일"]
day_of_week = weekdays[now.weekday()]
timestamp_str = now.strftime(f'%Y년 %m월 %d일 ({day_of_week}) %H:%M')

with open('README.md', 'w', encoding='utf-8') as f:
    f.write('### 🧩 Daily Algorithm\n\n')
    f.write(f'    🔥 지금까지 {total_count}개의 문제를 풀었습니다.\n')
    f.write(f'    ⏰ {timestamp_str} 업데이트되었습니다.')
