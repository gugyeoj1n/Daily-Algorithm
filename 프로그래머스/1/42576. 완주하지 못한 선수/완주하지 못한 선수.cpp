#include <string>
#include <vector>
#include <unordered_map>

using namespace std;

string solution(vector<string> participant, vector<string> completion) {
    unordered_map<string, int> m;
    for(string s : participant) m[s]++;
    for(string s : completion) m[s]--;
    for(auto x : m) if(x.second) return x.first;
    return "";
}