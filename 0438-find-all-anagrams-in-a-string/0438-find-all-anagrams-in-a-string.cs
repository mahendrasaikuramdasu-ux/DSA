public class Solution {
    private bool check_string_matching(int[] s1_char, int[] s2_char){
        for(int i=0; i<27; i++){
            if(s1_char[i] != s2_char[i]){
                return false;
            }
        }
        return true;
    }

    private void CheckInclusion(string s1, string s2, ref IList<int> ans) {
        int n = s1.Length;
        int m = s2.Length;
        int[] s1_char = new int[27];
        for(int i=0; i<n; i++){
            char item = s1[i];
            int index = (item - 'a') + 1;
            s1_char[index]++;
        }
        int low = 0;
        int[] s2_char = new int[27];
        for(int j = 0; j<m; j++){
            char item = s2[j];
            int index = (s2[j] - 'a') + 1;
            s2_char[index]++;
            if(j-low +1 == n){
                bool isTrue = check_string_matching(s1_char, s2_char);
                if(isTrue){
                    ans.Add(low);
                }
                char item_low = s2[low];
                int index_low = (item_low - 'a') + 1;
                s2_char[index_low]--;
                low++;
            }
        }
    }
    public IList<int> FindAnagrams(string s, string p) {
        IList<int> ans = new List<int>();
        CheckInclusion(p, s, ref ans);
        return ans;
    }
}