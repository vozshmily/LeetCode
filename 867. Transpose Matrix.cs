public class Solution
{
    public int[][] Transpose(int[][] matrix)
    {

        int[][] ans = new int[matrix[0].Length][];
        for (int i = 0; i < matrix[0].Length; i++)
        {
            ans[i] = new int[matrix.Length];
        }

        for (int i = 0; i < matrix[0].Length; i++)
        {
            for (int j = 0; j < matrix.Length; j++)
            {
                ans[i][j] = matrix[j][i];
            }
        }
        return ans;
    }
}
