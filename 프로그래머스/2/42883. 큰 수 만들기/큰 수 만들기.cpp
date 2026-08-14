#include <string>
#include <vector>

using namespace std;

string solution(string number, int k) {
    string answer;
    answer.reserve(number.size());
    
    for(char d : number)
    {
        while(!answer.empty() && k > 0 && answer.back() < d)
        {
            answer.pop_back();
            k--;
        }
        answer.push_back(d);
    }
    
    while(k > 0)
    {
        answer.pop_back();
        k--;
    }
    
    return answer;
}