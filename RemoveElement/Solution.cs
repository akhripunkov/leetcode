namespace RemoveElement;

public class Solution
{
    // Example 1:
    //
    // Input: nums = [3,2,2,3], val = 3
    // Output: 2, nums = [2,2,_,_]
    // Explanation: Your function should return k = 2, with the first two elements of nums being 2.
    // It does not matter what you leave beyond the returned k (hence they are underscores).
    // Example 2:
    //
    // Input: nums = [0,1,2,2,3,0,4,2], val = 2
    // Output: 5, nums = [0,1,4,0,3,_,_,_]
    // Explanation: Your function should return k = 5, with the first five elements of nums containing 0, 0, 1, 3, and 4.
    // Note that the five elements can be returned in any order.
    //     It does not matter what you leave beyond the returned k (hence they are underscores).
    //

    public int RemoveElement(int[] nums, int val)
    {
        var i = 0;
        var j = 0;
        while (i < nums.Length) 
        {
            if (nums[i] == val)
            {
                Shift(nums, i);
                j++;
                continue;
            }

            i++;
        }

        return nums.Length - j;
    }

    public void Shift(int[] nums, int pos)
    {
        for (int i = pos; i < nums.Length - 1; i++)
        {
            nums[i] = nums[i + 1];
        }

        nums[nums.Length - 1] = -1;
    }
    
    public int RemoveElementBest(int[] nums, int val)
    {
        int pos = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[pos] = nums[i];
                pos++;
            }
        }

        return pos;
    }
}