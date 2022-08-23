public class Solution
{
    public int Reverse(int x)
    {

        if (x <= Int32.MinValue || x >= Int32.MaxValue) return 0;

        int result = 0;
        int prev = 0;
        bool isPositive;

        if (x >= 0)
            isPositive = true;
        else
            isPositive = false;


        x = Math.Abs(x);

        while (x > 0)
        {
            int currentDigit = x % 10;
            result = (result * 10) + currentDigit;
            if ((result - currentDigit) / 10 != prev)
                return 0;
            prev = result;
            x = x / 10;
        }
        if (isPositive == true)
            return result;
        return result * -1;
    }
}