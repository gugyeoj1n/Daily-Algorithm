#include <string>
#include <vector>
#include <queue>
#include <algorithm>

using namespace std;

int solution(vector<int> priorities, int location) {
    int answer = 0;
    
    queue<pair<int, int>> q;
    for(int i = 0; i < priorities.size(); i++)
        q.push({ priorities[i], i });
    
    while(!q.empty())
    {
        int cur = q.front().first, idx = q.front().second;
        q.pop();
        bool check = false;
        queue<pair<int, int>> temp = q;
        
        while(!temp.empty())
        {
            if(temp.front().first > cur) {
                check = true;
                break;
            }
            temp.pop();
        }
        
        if(check) q.push({ cur, idx });
        else {
            answer++;
            if(idx == location) return answer;
        }
    }
    
    return answer;
}