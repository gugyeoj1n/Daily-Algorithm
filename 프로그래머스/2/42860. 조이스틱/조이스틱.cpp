#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int solution(string name) {
    int answer = 0;
    int n = name.size();
    int h = n - 1;
    
    for(int i = 0; i < n; i++)
    {
        int up = name[i] - 'A';
        int down = 'Z' - name[i] + 1;
        answer += min(up, down);
        
        int next = i + 1;
        while(next < n && name[next] == 'A')
            next++;
        
        int r = i * 2 + (n - next), l = i + (n - next) * 2;
        h = min(h, min(r, l));
    }
    
    return answer + h;
}