namespace MedianOfTwoSortedArrays;

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var nums3 = new List<int>(nums1);
        nums3.AddRange(nums2);
        nums3.Sort();
        var count = nums3.Count;
        double result;
        if (nums3.Count % 2 == 1)
        {
            result = nums3[count / 2];
        }
        else
        {
            result = (nums3[count / 2 - 1] + nums3[count / 2]) / 2.0;
        }

        return result;
    }
    
    public double FindMedianSortedArraysNew(int[] nums1, int[] nums2)
    {
        var nums3 = MergeSortArrays(nums1, nums2);
        var count = nums3.Length;
        double result;
        if (nums3.Length % 2 == 1)
        {
            result = nums3[count / 2];
        }
        else
        {
            result = (nums3[count / 2 - 1] + nums3[count / 2]) / 2.0;
        }

        return result;
    }

    private int[] MergeSortArrays(int[] nums1, int[] nums2)
    {
        int n = nums1.Length;
        int m = nums2.Length;
        int[] result = new int[n + m];

        int i = 0, j = 0, k = 0;
        while (i < n && j < m)
        {
            if (nums1[i] < nums2[j])
            {
                result[k] = nums1[i];
                i++;
            }
            else
            {
                result[k] = nums2[j];
                j++;
            }

            k++;
        }

        while (i < n)
        {
            result[k] = nums1[i];
            i++;
            k++;
        }
        
        while (j < m)
        {
            result[k] = nums2[j];
            j++;
            k++;
        }

        return result;
    }
    
    public double FindMedianSortedArraysNew2(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
        {
            return FindMedianSortedArrays(nums2, nums1);
        }

        int m = nums1.Length, n = nums2.Length;
        int left = 0, right = m;

        while (left <= right)
        {
            int partitionA = (left + right) / 2;
            int partitionB = (m + n + 1) / 2 - partitionA;

            int maxLeftA = (partitionA == 0) ? int.MinValue : nums1[partitionA - 1];
            int minRightA = (partitionA == m) ? int.MaxValue : nums1[partitionA];
            int maxLeftB = (partitionB == 0) ? int.MinValue : nums2[partitionB - 1];
            int minRightB = (partitionB == n) ? int.MaxValue : nums2[partitionB];

            if (maxLeftA <= minRightB && maxLeftB <= minRightA)
            {
                if ((m + n) % 2 == 0)
                {
                    return (Math.Max(maxLeftA, maxLeftB) + Math.Min(minRightA, minRightB)) / 2.0;
                }
                else
                {
                    return Math.Max(maxLeftA, maxLeftB);
                }
            }
            else if (maxLeftA > minRightB)
            {
                right = partitionA - 1;
            }
            else
            {
                left = partitionA + 1;
            }
        }
        return 0.0;
    }
}
    