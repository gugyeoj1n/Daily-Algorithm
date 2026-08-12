#include <string>
#include <vector>
#include <unordered_map>

using namespace std;

int solution(vector<vector<string>> clothes) {
    unordered_map<string, int> m;
    for(auto c : clothes) m[c[1]]++;
    int answer = 1;
    for(auto x : m) answer *= x.second + 1;
    return answer - 1;
}