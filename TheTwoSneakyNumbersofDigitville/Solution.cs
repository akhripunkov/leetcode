namespace TheTwoSneakyNumbersofDigitville;

public class Solution
{
    public int[] GetSneakyNumbers(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var num in nums) 
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict[num] = 1;
            }
        }

        var result = dict.Where(kvp => kvp.Value > 1).Select(kvp => kvp.Key).ToArray();
        return result;
    }
}