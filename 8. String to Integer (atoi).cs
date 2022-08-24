public class Solution
{
    public int MyAtoi(string s)
    {
        double num = 0;
        s = s.Trim();
        bool wasNum = false;

        string outStr = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (!(wasNum) && i != s.Length - 1 && ((s[i] == '-' || s[i] == '+') && (s[i + 1] >= '0' && s[i + 1] <= '9')))
            {
                outStr += s[i];
            }
            else if (s[i] >= '0' && s[i] <= '9')
            {
                wasNum = true;
                outStr += s[i];
            }
            else break;
        }
        double.TryParse(outStr, out num);
        if (num < int.MinValue) return int.MinValue;
        if (num > int.MaxValue) return int.MaxValue;
        return (int)num;
    }
}