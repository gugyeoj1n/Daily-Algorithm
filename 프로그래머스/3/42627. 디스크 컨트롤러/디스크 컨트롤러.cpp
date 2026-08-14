#include <string>
#include <vector>
#include <queue>
#include <algorithm>

using namespace std;

struct Compare {
    bool operator()(const vector<int>& a, const vector<int>& b) const {
        if(a[1] != b[1]) return a[1] > b[1];
        if(a[0] != b[0]) return a[0] > b[0];
        return a[2] > b[2];
    }
};

int solution(vector<vector<int>> jobs) {
    vector<vector<int>> tasks;
    for(int i = 0; i < jobs.size(); i++)
        tasks.push_back({ jobs[i][0], jobs[i][1], i });
    
    sort(tasks.begin(), tasks.end());
    
    priority_queue<vector<int>, vector<vector<int>>, Compare> pq;
    int currentTime = 0, idx = 0, total = 0, n = tasks.size();
    
    while(idx < n || !pq.empty())
    {
        while(idx < n && tasks[idx][0] <= currentTime)
        {
            pq.push(tasks[idx]);
            idx++;
        }
        
        if(pq.empty())
        {
            currentTime = tasks[idx][0];
            continue;
        }
        
        vector<int> job = pq.top();
        pq.pop();
        
        currentTime += job[1];
        total += currentTime - job[0];
    }
    
    return total / n;
}