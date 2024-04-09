namespace TwoSum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var result = new int[2];
        for (int j = 0; j < nums.Length; j++)
        {
            var temp = nums[j];
            result[0] = j;
            for (int i = j + 1; i < nums.Length; i++)
            {
                if (temp + nums[i] == target)
                {
                    result[1] = i;
                    return result;
                }
            }
        }

        return result;
    }

    public int[] TwoSumN1(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();
                          
                                  for (int i = 0; i < nums.Length; i++)
                                  {
                                      var numberToFind = target - nums[i];
                                      if (dict.ContainsKey(numberToFind))
                                      {
                                          return new[] { dict[numberToFind], i };
                                      }
                                      else
                                      {
                                          dict[nums[i]] = i;
                                      }
                                  }
                          
                                  return new int[2];
    }
}