public class Solution {
    public int MaxArea(int[] height) {
        int n = height.Length;
        int l = 0;
        int h = n-1;
        int water = 0;
        while(l < h){
            int curr_water = ((h-l) * (Math.Min(height[l], height[h])));
            water = Math.Max(water, curr_water);
            if(height[l] <= height[h]){
                l+=1;
            }
            else{
                h-=1;
            }
        }
        return water;
    }
}