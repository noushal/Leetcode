/**
 * @param {number[]} nums
 * @return {number}
 */
var findNonMinOrMax = function(nums) {
 
 
 let arr =   nums.sort((a,b)=>a-b);

   if(arr.length <= 2)   {
   return -1;
   }
    return arr[1];
};