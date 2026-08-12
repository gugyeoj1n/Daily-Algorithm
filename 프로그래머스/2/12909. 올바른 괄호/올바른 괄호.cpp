#include <string>
#include <iostream>
#include <stack>

using namespace std;

bool solution(string s)
{
    int a = 0;
    for(char i : s)
    {
        if(i == '(') a++;
        else {
            a--;
            if(a < 0) return false;
        }
    }
    
    if(a != 0) return false;
    return true;
        
}