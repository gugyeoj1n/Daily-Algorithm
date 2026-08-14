#include <string>
#include <vector>

using namespace std;

int solution(int n, vector<int> lost, vector<int> reserve) {
    int answer = 0;
    vector<int> clothes(n + 2, 1);
    
    for(int s : lost) clothes[s]--;
    for(int s : reserve) clothes[s]++;
    
    for(int i = 1; i <= n; i++)
    {
        if(clothes[i] != 0) continue;
        if(clothes[i - 1] == 2)
        {
            clothes[i - 1]--;
            clothes[i]++;
        } else if(clothes[i + 1] == 2)
        {
            clothes[i + 1]--;
            clothes[i]++;
        }
    }
    
    for(int i = 1; i <= n; i++)
        if(clothes[i] >= 1) answer++;
    
    return answer;
}