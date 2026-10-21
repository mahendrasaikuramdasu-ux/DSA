public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int n = nums.Length;
        int maxi = 0;
        Dictionary<int, int> store = new Dictionary<int, int>();
        store.Add(0,1);
        int ans = 0;
        for(int i=0; i<n; i++){
            int curr = nums[i];
            maxi += curr;
            int isThere = maxi - k;
            if(store.ContainsKey(isThere)){
                ans += store[isThere];
            }
            if(!store.ContainsKey(maxi)){
                store.Add(maxi, 0);
            }
            store[maxi] += 1;
        }
        return ans;
    }
}