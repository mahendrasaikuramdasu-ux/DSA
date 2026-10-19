public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int n = nums.Length;
        for(int i=0; i<n; i++){
            int ele = nums[i];
            while(ele -1 != i && ele > 0 && ele <= n && ele != nums[ele-1]){
                (nums[i], nums[ele-1]) = (nums[ele-1], nums[i]);
                ele = nums[i];
            }
        }
        for (int i=0; i<n; i++){
            if(nums[i] != i+1){
                return i+1;
            }
        }
        return n+1;
    }
}