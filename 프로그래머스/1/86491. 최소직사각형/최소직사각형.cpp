#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int solution(vector<vector<int>> sizes) {
    int w = 0, h = 0;
    for(auto s : sizes)
    {
        if(s[0] < s[1]) swap(s[0], s[1]);
        w = max(w, s[0]);
        h = max(h, s[1]);
    }
    
    return w * h;
}