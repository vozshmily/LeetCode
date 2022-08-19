public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l=0;
        int r=numbers.Length-1;
        
        while(l<r){
            if(numbers[l]+numbers[r]<target)
                l++;
            else if(numbers[l]+numbers[r]>target)
                r--;
            else
                return new int[]{l+1,r+1};
        }
        return null;
    }
}