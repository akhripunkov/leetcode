// See https://aka.ms/new-console-template for more information

//Console.WriteLine(MinSubArrayLen(7, new []{2,3,1,2,4,3}));
Console.WriteLine(MinSubArrayLen(11, new []{1,2,3,4,5}));


int MinSubArrayLen(int target, int[] nums) {
    int windowSum = nums[0];
    int minLen = 0;
    int left = 0, right = 0;
    while(left < nums.Length && right < nums.Length)
    {
        if (windowSum < target)
        {
            right++;
            if (right >= nums.Length) break;
            windowSum += nums[right];
        }
        else 
        {
            minLen = minLen > 0 ? Math.Min(minLen, right - left + 1) : right - left + 1;
            windowSum -= nums[left];
            left++;
        }
    }

    return minLen;
}

int MinSubArrayLenEQUALTARGET(int target, int[] nums)
{
    int windowSum = nums[0];
    int minLen = 0;

    int left = 0, right = 0;
    while(left < nums.Length && right < nums.Length)
    {
        if (windowSum < target)
        {
            right++;
            if (right >= nums.Length) break;
            
            windowSum += nums[right];
        }
        else if (windowSum > target)
        {
            windowSum -= nums[left];
            left++;
        }
        else
        {
            minLen = minLen > 0 ? Math.Min(minLen, right - left + 1) : right - left + 1;
            right++;
            if (right >= nums.Length) break;
            windowSum += nums[right];
        }
        
    }

    return minLen;
}