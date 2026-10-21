public class Solution {

    private int find_par(int item, ref Dictionary<int,int> par){
        if(par[item] == int.MinValue){
            return item;
        }
        int parent = find_par(par[item], ref par);
        par[item] = parent;
        return parent;
    }

    private void union(int ele_1, int ele_2, ref Dictionary<int,int> par, ref Dictionary<int,int> deg, ref int max_deg){
        int par_1 = find_par(ele_1, ref par);
        int par_2 = find_par(ele_2, ref par);
        if(par_1 == par_2){
            return;
        }
        if(deg[par_1] >= deg[par_2]){
            par[par_2] = par_1;
            deg[par_1] = deg[par_1] + deg[par_2];
            max_deg = Math.Max(deg[par_1], max_deg);
        }
        else{
            par[par_1] = par_2;
            deg[par_2] = deg[par_1] + deg[par_2];
            max_deg = Math.Max(deg[par_2], max_deg);
        }
    }

    public int LongestConsecutive(int[] nums) {
        int n = nums.Length;
        if(n == 0){
            return 0;
        }
        if(n == 1){
            return 1;
        }
        Dictionary<int,int> par = new Dictionary<int, int>();
        Dictionary<int,int> deg = new Dictionary<int, int>();
        int max_deg = 0;
        for(int i=0; i<n; i++){
            if(par.ContainsKey(nums[i]) && deg.ContainsKey(nums[i])){
                continue;
            }   
            par.Add(nums[i], int.MinValue);
            deg.Add(nums[i], 1);
            max_deg = Math.Max(max_deg, deg[nums[i]]);
            if(par.ContainsKey(nums[i] -1)){
                union(nums[i], nums[i]-1, ref par, ref deg, ref max_deg);
            }
            if(par.ContainsKey(nums[i] +1)){
                union(nums[i], nums[i]+1, ref par, ref deg, ref max_deg);
            }
        }
        return max_deg;
    }
}