namespace FirstMissingPositive;

public class Solution {
    public int FirstMissingPositive(int[] nums) {
        var list = new List<int>(nums);
        var hash = new HashSet<int>(nums);

        int minListPositiveValue = Int32.MaxValue;
        foreach (var val in list)
        {
            if (val > 0 && val < minListPositiveValue)
            {
                    minListPositiveValue = val;
            }
        }

        if (minListPositiveValue > 1)
            return 1;
        
        for (int i = 2; i < nums.Length; i++)
        {
            if (!hash.Contains(i))
                return i;
        }

        return 0;
    }
}