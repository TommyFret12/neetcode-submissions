public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] output = new int[nums.Length];
        int sum = 1;
        int zeroCount = 0;
        for(int i = 0; i< nums.Length;i++){
            if(nums[i] == 0){
                zeroCount +=1;
                continue;
            }
            sum *= nums[i];

        }
        for(int i = 0;i<nums.Length;i++){
            if(zeroCount > 0 &&nums[i] != 0){
                output[i] = 0;
            }
            else if(nums[i] == 0 && zeroCount >1){
                output[i] = 0;

            }
            else if(nums[i] == 0 && zeroCount == 1){
                output[i] = sum;
            }
            else{
                output[i] = sum /nums[i];
            }
        }
        return output;
        }
        
        
}
