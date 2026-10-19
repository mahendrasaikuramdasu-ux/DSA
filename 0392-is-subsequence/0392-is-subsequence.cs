public class Solution {
    public bool IsSubsequence(string s, string t) {
        int n = s.Length;
        int m = t.Length;
        if(n > m){
            return false;
        }
        if(n == m){
            return s == t ? true : false;
        }
        int cnt = 0;
        for(int i=0; i<m; i++){
            if(cnt == n) return true;
            if(s[cnt] == t[i]){
                cnt += 1;
            }
        }
        return cnt == n ? true : false;
    }
}