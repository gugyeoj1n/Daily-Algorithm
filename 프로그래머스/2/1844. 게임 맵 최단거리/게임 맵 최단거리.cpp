#include <vector>
#include <queue>
using namespace std;

int solution(vector<vector<int>> maps)
{
    int n = maps.size(), m = maps[0].size();
    queue<pair<int, int>> q;
    
    int dx[4] = { -1, 1, 0, 0 };
    int dy[4] = { 0, 0, -1, 1 };
    
    q.push({ 0, 0 });
    while(!q.empty())
    {
        int x = q.front().first, y = q.front().second;
        q.pop();
        
        for(int i = 0; i < 4; i++)
        {
            int nx = x + dx[i], ny = y + dy[i];
            if(nx < 0 || nx >= n || ny < 0 || ny >= m) continue;
            if(maps[nx][ny] == 0) continue;
            
            if(maps[nx][ny] == 1)
            {
                maps[nx][ny] = maps[x][y] + 1;
                q.push({ nx, ny });
            }
        }
    }
    
    if(maps[n - 1][m - 1] == 1) return -1;
    return maps[n - 1][m - 1];
}