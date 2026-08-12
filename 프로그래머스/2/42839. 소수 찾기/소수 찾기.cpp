#include <string>
#include <vector>
#include <set>
#include <algorithm>

using namespace std;

bool isPrime(int n) {
    for(int i = 2; i * i <= n; i++)
        if(n % i == 0) return false;
    return n > 1;
}

int solution(string numbers) {
    int answer = 0;
    set<int> s;
    sort(numbers.begin(), numbers.end());
    
    do {
        for(int i = 1; i <= numbers.size(); i++)
            s.insert(stoi(numbers.substr(0, i)));
    } while(next_permutation(numbers.begin(), numbers.end()));
    
    for(int x : s)
        if(isPrime(x)) answer++;
    
    return answer;
}