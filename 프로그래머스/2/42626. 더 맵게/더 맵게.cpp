#include <string>
#include <vector>
#include <queue>
#include <functional>

using namespace std;

int solution(vector<int> scoville, int K) {
    priority_queue<long long, vector<long long>, greater<long long>> pq(scoville.begin(), scoville.end());
    int answer = 0;

    while(!pq.empty() && pq.top() < K) {
        if(pq.size() < 2) return -1;
        
        long long first = pq.top();
        pq.pop();
        long long second = pq.top();
        pq.pop();
        
        pq.push(first + second * 2);
        answer++;
    }
    
    return answer;
}