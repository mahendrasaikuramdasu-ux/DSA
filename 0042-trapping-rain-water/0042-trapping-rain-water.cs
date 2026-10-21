public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int[] suffix = new int[n];
        int maxi = 0;
        for(int i=n-1; i>=0; i--){
            suffix[i] = maxi;
            maxi = Math.Max(maxi, height[i]);
        }

        int total = 0;
        maxi = 0;
        for(int i=0; i<n; i++){
            int curr_capacity_height = Math.Min(maxi, suffix[i]);
            int curr_water = curr_capacity_height - height[i];
            if(curr_water > 0){
                total += curr_water;
            }
            maxi = Math.Max(maxi, height[i]);
        }
        return total;
    }
}