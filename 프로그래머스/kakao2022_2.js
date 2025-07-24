function solution(n, k) {
    let answer = 0;
    
    const isPrime = (num) => {
        if(num === 2) return true;
        if(num === 1) return false;
        else {
            for(let i = 2; i < Math.sqrt(num) + 1; i++) {
                if(num % i === 0) return false;
        }}
        
        return true;
    }
    
    let changed = n.toString(k).split("0").filter(item => item !== "");
    
    for (const idx in changed) {
        if(isPrime(parseInt(changed[idx]))) answer += 1;
    }
    
    return answer;
}
