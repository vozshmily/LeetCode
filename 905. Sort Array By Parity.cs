public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int len = nums.Length;
		
        int[] resNums = new int[len];
        
        for(int i = 0, j = 0, k = len-1; i < nums.Length; i++)
        {
            if(nums[i] % 2 == 0)
            {
                resNums[j] = nums[i];
                j++;
            }
            else
            {
                resNums[k] = nums[i];
                k--;
            }
        }
        return resNums;
    }
}