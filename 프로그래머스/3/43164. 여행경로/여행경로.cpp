#include <string>
#include <vector>
#include <algorithm>

using namespace std;

vector<string> answer;
vector<bool> visited;

bool dfs(string cur, vector<vector<string>>& tickets, vector<string>& path, int cnt)
{
    path.push_back(cur);
    if(cnt == tickets.size()) {
        answer = path;
        return true;
    }
    
    for(int i = 0; i < tickets.size(); i++)
    {
        if(!visited[i] && tickets[i][0] == cur)
        {
            visited[i] = true;
            if(dfs(tickets[i][1], tickets, path, cnt + 1)) return true;
            visited[i] = false;
        }
    }
    
    path.pop_back();
    return false;
}

vector<string> solution(vector<vector<string>> tickets) {
    sort(tickets.begin(), tickets.end());
    visited.assign(tickets.size(), false);
    vector<string> path;
    dfs("ICN", tickets, path, 0);
    return answer;
}