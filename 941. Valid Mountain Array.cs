public class Solution
{
    public bool ValidMountainArray(int[] arr)
    {
        if (arr.Length < 3) return false;

        bool decreased = false;
        bool increased = false;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > arr[i - 1])
            {
                if (decreased) return false;
                increased = true;
            }
            else if (arr[i] < arr[i - 1])
            {
                if (!increased) return false;
                decreased = true;
            }
            else return false;
        }

        return decreased && increased;
    }
}