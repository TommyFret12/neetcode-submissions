public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> myDict = new Dictionary<string,List<string>>();
        foreach(string s in strs){
            int[] count = new int[26];
            foreach(char c in s){
                count[c -'a']++;
            }
            string key = String.Join(", ", count);
            if(!myDict.ContainsKey(key)){
                myDict[key] = new List<string>();
            }
            myDict[key].Add(s);

        }
        return myDict.Values.ToList<List<string>>();

        
    }
}
