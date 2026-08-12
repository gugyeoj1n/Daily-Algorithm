#include <string>
#include <vector>
#include <queue>

using namespace std;

int solution(int bridge_length, int weight, vector<int> truck_weights) {
    int time = 0, sum = 0, idx = 0;
    queue<int> bridge;
    for (int i = 0; i < bridge_length; i++) bridge.push(0);
    
    while(idx < truck_weights.size())
    {
        time++;
        sum -= bridge.front();
        bridge.pop();
        
        if(sum + truck_weights[idx] <= weight)
        {
            bridge.push(truck_weights[idx]);
            sum += truck_weights[idx];
            idx++;
        } else {
            bridge.push(0);
        }
    }
    
    return time + bridge_length;
}