#include <string>
#include <vector>

using namespace std;

vector<int> solution(int brown, int yellow) {
    for(int h = 1; h <= yellow; h++)
    {
        if(yellow % h == 0) {
            int w = yellow / h;
            if((w + 2) * (h + 2) == brown + yellow) return { w + 2, h + 2 };
        }
    }
    return { };
}