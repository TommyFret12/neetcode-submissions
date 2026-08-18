public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int difference;
        
        
        Dictionary <int,int> hashMap = new Dictionary<int,int>();
        for(int i = 0; i<nums.Length;i++){
            difference = target-nums[i];
            if(hashMap.ContainsKey(difference)){
                return new int[]{hashMap[difference],i};
            }
            else{
                hashMap[nums[i]] = i;
            }
            
        }
        return null;
        
    }
}
