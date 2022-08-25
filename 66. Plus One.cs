public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i > -1; i--)
        {
            digits[i]++;
            if (i > 0 && digits[i] > 9)
            {
                digits[i] = 0;
            }
            else
            {
                break;
            }
        }
        if (digits[0] == 10)
        {
            Array.Reverse(digits);
            Array.Resize(ref digits, digits.Length + 1);
            Array.Reverse(digits);
            digits[0] = 1;
            digits[1] = 0;
        }
        return digits;
    }
}