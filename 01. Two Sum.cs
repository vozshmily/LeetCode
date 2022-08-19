public class Solution {
    public int[] TwoSum(int[] nums, int target) {
     
        for(int i=1;i<nums.Length;i++){
            for(int j=i;j<nums.Length;j++){
                if(nums[j - i] + nums[j] == target){
                   return new int[]{j - i,j};
                }
            }
        }
        return null;
    }
}