using System.Collections.Generic;

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> num_set = new HashSet<int>();
        foreach(int i in nums){
            if(num_set.Contains(i)){
                return true;
            }
            num_set.Add(i);
        }
        return false;
    }
}