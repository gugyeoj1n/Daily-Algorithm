function solution(id_list, report, k) {
    let answer = new Array(id_list.length).fill(0); // 메일 수 저장용
    const filterSet = new Set(report);
    let _report = [...filterSet]; // 중복 제거로 동일한 신고 없애기
    let reported = {};
    
    id_list.map(name => {
        reported[name] = [];
    });
    
    _report.map((item) => { // reported key: 신고당한 사람, value: 신고한 사람
        let [first, second] = item.split(" ");
        if(first in reported[second] === false) {
            reported[second].push(first)
    }})
    
    Object.keys(reported).map((name) => {
        if(reported[name].length >= k) {
            reported[name].map((user) => {
                answer[id_list.indexOf(user)] += 1;
            })
        }
    })
    
    return answer;
}
