#include <string>
#include <vector>
#include <algorithm>

using namespace std;

vector<int> solution(vector<int> array, vector<vector<int>> commands) {
    vector<int> result;
    for(auto x : commands)
    {
        vector<int> sliced(array.begin() + x[0] - 1, array.begin() + x[1]);
        sort(sliced.begin(), sliced.end());
        result.push_back(sliced[x[2] - 1]);
    }
    return result;
}