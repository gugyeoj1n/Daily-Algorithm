using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int l, int r) {
        int[] answer = new int[] {};
        
        answer = Enumerable.Range(l, r - l + 1).Where(x => x.ToString().All(y => y == '5' || y == '0')).ToArray();
        if(answer.Length <= 0)
            return new int[] { -1 };
        
        return answer;
    }
}