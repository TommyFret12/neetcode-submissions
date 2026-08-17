public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length !=t.Length){
            return false;
        }

        Dictionary<char, int> myDictS = new Dictionary<char, int>();
        Dictionary<char, int> myDictT = new Dictionary<char,int>();

        for(int i =0;i<s.Length; i++){
            if(myDictS.ContainsKey(s[i])){
                myDictS[s[i]] = myDictS[s[i]] + 1;
            }
            else{
                myDictS[s[i]] = 1;
            }
            if(myDictT.ContainsKey(t[i])){
                myDictT[t[i]] = myDictT[t[i]] + 1;
            }
            else{
                myDictT[t[i]] = 1;
            }
        }
        return myDictT.Count == myDictS.Count && !myDictS.Except(myDictT).Any();
    }
}
