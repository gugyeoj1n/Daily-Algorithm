#include <string>
#include <vector>
#include <algorithm>
#include <unordered_map>

using namespace std;

vector<int> solution(vector<string> genres, vector<int> plays) {
    vector<int> answer;
    unordered_map<string, int> total;
    unordered_map<string, vector<pair<int, int>>> songs;
    
    for(int i = 0; i < genres.size(); i++)
    {
        total[genres[i]] += plays[i];
        songs[genres[i]].push_back({ plays[i], i });
    }
    
    vector<pair<string, int>> order;
    for(auto x : total) order.push_back({ x.first, x.second });
    sort(order.begin(), order.end(), [](pair<string, int> a, pair<string, int> b) {
        return a.second > b.second;
    });
    
    for(auto x : order)
    {
        auto& v = songs[x.first];
        sort(v.begin(), v.end(), [](pair<int, int> a, pair<int, int> b) {
            if(a.first == b.first) return a.second < b.second;
            return a.first > b.first;
        });
        
        answer.push_back(v[0].second);
        if(v.size() > 1) answer.push_back(v[1].second);
    }
    

    return answer;
}