public class Solution {

    public int countBits(int num, int n){
        int bit = 1;
        int cnt = 0;
        for(int i=0; i<=n; i++){
            int a = num & bit;
            if(a != 0){
                cnt+=1;
            }
            bit = bit << 1;
        }
        return cnt;
    }

    public int[] CountBits(int n) {
        int[] ans = new int[n+1];
        for(int i=0; i<=n; i++){
            ans[i] = countBits(i, n);
        }
        return ans;
    }
}