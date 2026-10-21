public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        int n = strs.Length;
        Dictionary<string, List<int>> store = new Dictionary<string, List<int>>();
        for(int i=0; i<n; i++){
            char[] chars = strs[i].ToCharArray();
            Array.Sort(chars);
            string item = new string(chars);
            if(store.ContainsKey(item)){
                store[item].Add(i);
            }
            else{
                store.Add(item, new List<int> { i });
            }
        }
        IList<IList<string>> ans = new List<IList<string>>();
        int index = 0;
        foreach(KeyValuePair<string, List<int>> j in store){
            List<string> group = new List<string>();
            ans.Add(group);
            foreach(int k in j.Value){
                ans[index].Add(strs[k]);
            }
            index+=1;
        }
        return ans;
    }
}