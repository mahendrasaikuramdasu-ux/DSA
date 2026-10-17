public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int product = 1;
        int[] ans = new int[n];
        for (int i=0; i<n; i++){
            ans[i] = 0;
        }
        int zeros = 0;
        int zero_index = -1;
        foreach(var (ele, index) in nums.Select((v,i) => (v,i))){
            if(ele == 0){
                zeros += 1;
                zero_index = index;
                if(zeros > 1){
                    return ans;
                }
            }
            else{
                product = product * ele;
            }
        }
        if(zeros == 1){
            ans[zero_index] = product;
            return ans;
        }
        foreach(var (ele, index) in nums.Select((v,i) => (v,i))){
            ans[index] = product / ele;
        }
        return ans;
    }
}