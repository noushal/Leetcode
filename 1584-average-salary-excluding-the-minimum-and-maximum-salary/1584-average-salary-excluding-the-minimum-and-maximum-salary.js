/**
 * @param {number[]} salary
 * @return {number}
 */
var average = function(salary) {
    var sum = 0;
    for(let i = 0; i < salary.length; i++){
        sum += salary[i];
    }
    sum -= Math.max(...salary)
    sum -= Math.min(...salary)
    return sum / (salary.length - 2)
};