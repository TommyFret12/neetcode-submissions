public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int difference;
        Dictionary<int,int> myDict = new Dictionary<int,int>();
        for(int i = 0;i<nums.Length; i++){
            difference = target - nums[i];
            if(myDict.ContainsKey(difference)){
                return new int[] {myDict[difference],i};
            }
            else{
                myDict[nums[i]] = i;
            }
        }
        return null;
    }
}
