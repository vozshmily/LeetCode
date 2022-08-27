public class Solution
{
    public string AddBinary(string a, string b)
    {
        var sb = new StringBuilder();
        var carry = 0;

        for (int i = a.Length - 1, j = b.Length - 1; i >= 0 || j >= 0; i--, j--)
        {
            var adigit = i >= 0 ? (a[i] == '0' ? 0 : 1) : 0;
            var bdigit = j >= 0 ? (b[j] == '0' ? 0 : 1) : 0;
            var sum = carry + adigit + bdigit;
            if (sum > 1)
            {
                sum %= 2;
                carry = 1;
            }
            else
                carry = 0;

            sb.Insert(0, sum);
        }

        if (carry > 0)
            sb.Insert(0, "1");

        return sb.ToString();
    }
}