using System.Text;

namespace LargestNumber;

// Example 1:
//
// Input: nums = [10,2]
// Output: "210"

// Example 2:
//
// Input: nums = [3,30,34,5,9]
// Output: "9534330"

public class Solution
{
    public string LargestNumber(int[] nums)
    {
        var numStrs = nums.Select(n => n.ToString()).ToArray();
        Array.Sort(numStrs, (a, b) => (b + a).CompareTo(a + b));
        string result = string.Join("", numStrs);
        return result.StartsWith("0") ? "0" : result;
    }
}