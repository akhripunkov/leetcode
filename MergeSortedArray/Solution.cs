namespace MergeSortedArray;

// Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
// Output: [1,2,2,3,5,6]
// Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
//     The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
//     Example 2:
//
// Input: nums1 = [1], m = 1, nums2 = [], n = 0
// Output: [1]
// Explanation: The arrays we are merging are [1] and [].
//     The result of the merge is [1].
// Example 3:

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int j = 0;
        for (int i = m; i < m + n; i++)
        {
            nums1[i] = nums2[j];
            j++;
        }
        
        for (int i = 0; i < m + n; i++)
        {
            for (int k = i + 1; k < m + n; k++)
            {
                if (nums1[i] > nums1[k])
                {
                    var temp = nums1[i];
                    nums1[i] = nums1[k];
                    nums1[k] = temp;
                }
            }
        }
    }
}