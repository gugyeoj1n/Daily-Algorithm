#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int solution(vector<int> people, int limit) {
    sort(people.begin(), people.end());
    int left = 0, right = people.size() - 1, answer = 0;

    while(left <= right)
    {
        if(people[left] + people[right] <= limit)
            left++;
        right--;
        answer++;
    }
    
    return answer;
}