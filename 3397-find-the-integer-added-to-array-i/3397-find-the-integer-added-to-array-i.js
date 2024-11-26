/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number}
 */
var addedInteger = function(nums1, nums2) {
    let x = 0
    x = Math.min(...nums2) - Math.min(...nums1)
    return x
};