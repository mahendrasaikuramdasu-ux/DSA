public class Solution {
    public int TotalFruit(int[] fruits) {
        int n = fruits.Length;
        Dictionary<int, int> map = new Dictionary<int, int>();
        int ans = 0;
        int curr = 0;
        int low = 0;
        for(int i=0; i<n; i++){
            int fruit = fruits[i];
            curr+=1;
            if(map.ContainsKey(fruit)){
                map[fruit]+=1;
            }
            else{
                map.Add(fruit, 1);
            }
            while(i > low && low < n && map.Count > 2){
                int curr_low_fruit = fruits[low];
                map[curr_low_fruit]-=1;
                curr-=1;
                low+=1;
                if(map[curr_low_fruit] == 0){
                    map.Remove(curr_low_fruit);
                }
                
            }
            ans = Math.Max(ans, curr);
        }
        return ans;
    }
}