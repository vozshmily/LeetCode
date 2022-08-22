public class Solution
{
    public bool IsPalindrome(int x)
    {
        string num = x.ToString();

        int i = 0;
        int j = num.Length - 1;

        while (i < j)
        {
            if (num[i] != num[j])
                break;
            i++;
            j--;

        }
        if (num[i] == num[j])
            return true;
        return false;
    }
}