#include <string>
#include <vector>
#include <queue>

using namespace std;

int solution(vector<vector<int>> rectangle, int characterX, int characterY, int itemX, int itemY) {
    int board[102][102] = { 0 };
    bool visited[102][102] = { false };
    
    for(auto r : rectangle)
    {
        int x1 = r[0] * 2, y1 = r[1] * 2, x2 = r[2] * 2, y2 = r[3] * 2;
        for(int i = x1; i <= x2; i++)
        {
            for(int j = y1; j <= y2; j++)
            {
                if(board[i][j] == 2) continue;
                if(i == x1 || i == x2 || j == y1 || j == y2) board[i][j] = 1;
                else board[i][j] = 2;
            }
        }
    }
    
    queue<pair<pair<int, int>, int>> q;
    q.push({ { characterX * 2, characterY * 2 }, 0 });
    visited[characterX * 2][characterY * 2] = true;
    
    int dx[4] = { -1, 1, 0, 0 };
    int dy[4] = { 0, 0, -1, 1 };
    
    while(!q.empty())
    {
        int x = q.front().first.first, y = q.front().first.second;
        int dist = q.front().second;
        q.pop();
        
        if(x == itemX * 2 && y == itemY * 2) return dist / 2;
        
        for(int i = 0; i < 4; i++)
        {
            int nx = x + dx[i], ny = y + dy[i];
            if(nx < 0 || nx >= 102 || ny < 0 || ny >= 102) continue;
            if(visited[nx][ny] || board[nx][ny] != 1) continue;
            visited[nx][ny] = true;
            q.push({ { nx, ny }, dist + 1 });
        }
    }
    
    return 0;
}