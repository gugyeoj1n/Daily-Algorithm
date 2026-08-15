#include <string>
#include <vector>
#include <queue>

using namespace std;

bool canChange(string a, string b)
{
    int cnt = 0;
    for(int i = 0; i < a.size(); i++)
        if(a[i] != b[i]) cnt++;
    return cnt == 1;
}

int solution(string begin, string target, vector<string> words) {
    queue<pair<string, int>> q;
    vector<bool> visited(words.size(), false);
    
    q.push({ begin, 0 });
    
    while(!q.empty())
    {
        string cur = q.front().first;
        int step = q.front().second;
        q.pop();
        
        if(cur == target) return step;
        for(int i = 0; i < words.size(); i++)
        {
            if(canChange(cur, words[i]) && !visited[i])
            {
                visited[i] = true;
                q.push({ words[i], step + 1 });
            }
        }
    }
    
    return 0;
}