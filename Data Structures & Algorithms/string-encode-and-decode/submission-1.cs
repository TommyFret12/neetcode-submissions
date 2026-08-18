public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(string s in strs){
            sb.Append(s.Length).Append('#').Append(s);
        }
        return sb.ToString();
        
    }

    public List<string> Decode(string s) {
        List<string> myList = new List<string>();
        int i=0;
        while(i<s.Length){
            int j = i;
            while(s[j] != '#'){
                j++;
            }
            int length = int.Parse(s.Substring(i,j-i));
            i=j+1;
            j= i+length;
            myList.Add(s.Substring(i, length));
            i=j;
        }
        return myList;

   }
}
