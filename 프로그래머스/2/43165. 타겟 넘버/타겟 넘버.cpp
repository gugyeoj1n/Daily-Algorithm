#include <string>
#include <vector>

using namespace std;

int dfs(vector<int>& num, int t, int idx, int s)
{
    if(idx == num.size())
        return s == t ? 1 : 0;
    
    return dfs(num, t, idx + 1, s + num[idx]) +
           dfs(num, t, idx + 1, s - num[idx]);
}

int solution(vector<int> numbers, int target) 
{
    return dfs(numbers, target, 0, 0);
}