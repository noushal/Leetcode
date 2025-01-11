/**
 * @param {number[]} nums
 * @return {number[]}
 */
var distinctDifferenceArray = function(nums) {
    const n = nums.length;
    const diff = [];
    const prefixSet = new Set();
    const suffixSet = new Set();
    const suffixDistinct = Array(n+1).fill(0);

    for(let i = n - 1; i >= 0; i--){
        suffixSet.add(nums[i]);
        suffixDistinct[i] = suffixSet.size;
    }

    for(let i = 0; i < n; i++){
        prefixSet.add(nums[i]);
        diff.push(prefixSet.size - suffixDistinct[i + 1]);
    }
    return diff
};