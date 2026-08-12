#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> progresses, vector<int> speeds) {
    vector<int> answer, days;
    for(int i = 0; i < progresses.size(); i++)
        days.push_back((100 - progresses[i] + speeds[i] - 1) / speeds[i]);
    
    int cur = days[0], cnt = 1;
    
    for(int i = 1; i < days.size(); i++)
    {
        if(days[i] <= cur) cnt++;
        else {
            answer.push_back(cnt);
            cur = days[i];
            cnt = 1;
        }
    }
    
    answer.push_back(cnt);
    return answer;
}