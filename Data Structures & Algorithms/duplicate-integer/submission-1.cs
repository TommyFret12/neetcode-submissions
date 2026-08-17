public class Solution {
    public bool hasDuplicate(int[] nums) {
        int count = 0;
        HashSet<int> seen = new HashSet<int>();
        foreach(int num in nums){
            if(seen.Contains(num)){
                return true;
            }
            seen.Add(num);
        }
        return false;
        
    }
}