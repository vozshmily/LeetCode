public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        int[] ans = new int[nums.Length];
        ans[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            ans[i] = ans[i - 1] + nums[i];
        }
        return ans;
    }
}