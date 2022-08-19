public class Solution
{
    public int RomanToInt(string s)
    {


        int sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int first = Roman(s[i]);
            int second = 0;
            if (i + 1 < s.Length)
                second = Roman(s[i + 1]);

            if (first >= second)
            {
                sum += first;
            }
            else
                sum -= first;
        }
        return sum;
    }
    public int Roman(char x)
    {
        int num = 0;
        switch (x)
        {
            case 'M':
                num = 1000;
                break;
            case 'D':
                num = 500;
                break;
            case 'C':
                num = 100;
                break;
            case 'L':
                num = 50;
                break;
            case 'X':
                num = 10;
                break;
            case 'V':
                num = 5;
                break;
            case 'I':
                num = 1;
                break;
        }
        return num;
    }
}