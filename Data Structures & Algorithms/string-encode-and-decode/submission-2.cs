public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(string s in strs){
            sb.Append(s.Length).Append('#').Append(s);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        int i = 0;
        List<string> myList= new List<string>();
        while(i<s.Length){
            int j=i;
            while(s[j] != '#'){
                j+=1;
                
            }
            int stringLength = int.Parse(s.Substring(i,j-i));
            myList.Add(s.Substring(j+1,stringLength));
            
            i = j+1+stringLength;
            
        }
        
        return myList;

   }
}
