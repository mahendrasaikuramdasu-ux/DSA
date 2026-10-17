public class Solution {
    public int MajorityElement(int[] nums) {
        int n = nums.Length;
        int cnt = 0;
        int ele = nums[0];
        foreach(int i in nums){
            if (ele == i){
                ++cnt;
            }
            else if(ele != i){
                --cnt;
            }
            if(cnt < 0){
                cnt = 1;
                ele = i;
            }
        }
        if(cnt < 1){
            return int.MinValue;
        }
        cnt = 0;
        foreach(int i in nums){
            if (i == ele){
                cnt++;
            }
        }
        if(cnt >= (n/2)){
            return ele;
        }
        return int.MinValue;
    }
}