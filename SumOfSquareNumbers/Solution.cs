namespace SumOfSquareNumbers;

public class Solution {
    public bool JudgeSquareSum(int c) {
        for (int i = 1; i <= c; i++)
        {
            for (int j = 1; j <= c; j++)
            {
                var res = i*i + j*j;
                if (res == c)
                    return true;
            }
        }
        return false;
    }
}