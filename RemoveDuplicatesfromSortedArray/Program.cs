// See https://aka.ms/new-console-template for more information

var nums = new int[] { 1, 1, 2 };



int RemoveDuplicates(int[] nums)
{
    var pos = 1;
    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] != nums[i-1])
        {
            nums[pos] = nums[i]; 
            pos++;
        }
    }

    return pos;
}

int RemoveDuplicatesPartTwo(int[] nums)
{
    var pos = 1;
    var valCount = 1; 
    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] != nums[i-1])
        {
            nums[pos] = nums[i]; 
            pos++;
            valCount = 1;
        }
        else if (nums[i] == nums[i - 1])
        {
            if (valCount < 2)
            {
                nums[pos] = nums[i]; 
                pos++;
                valCount++;
            }
        }

    }

    return pos;
}