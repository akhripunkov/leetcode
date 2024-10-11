Console.WriteLine("Hello, World!");

var arr = new int[] { 7,0,9,6,9,6,1,7,9,0,1,2,9,0,3 }; // answer = 2
var arr2 = new int[] { 1,2 };
Console.WriteLine(CanJump(arr));
Console.WriteLine(Jump(arr2));


int Jump(int[] nums)
{
    if (nums.Length == 1) return 0;
    var jumpCount = 0;
    var jumpZone = 0;
    var maxIndex = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (jumpZone == 0)
        {
            jumpZone = nums[0];
            jumpCount++;
            if (jumpZone == 0) return 0;
            if (jumpZone > nums.Length - 1) return 1;
        }

        if (i < jumpZone)
        {
            maxIndex = Math.Max(maxIndex, nums[i] + i);
            var s = maxIndex;
        }
        else
        {
            jumpZone = Math.Max(maxIndex, nums[i] + i);
            jumpCount++;
            if (jumpZone >= nums.Length - 1)
                return jumpCount;
        }
    }

    return jumpCount;
}

int JumpBest(int[] nums) {
    var jumpCount = 0;
    var jumpZone = 0;
    var maxIndex = 0;
    for (int i = 0; i < nums.Length - 1; i++)
    {
        maxIndex = Math.Max(maxIndex, nums[i] + i);
        if (i == jumpZone)
        {
            jumpCount++;
            jumpZone = maxIndex;
        }
    }

    return jumpCount;
}
bool CanJump(int[] nums)
{
    var maxIndex = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (maxIndex < i)
            return false;

        maxIndex = Math.Max(maxIndex, nums[i] + i);
    }

    return true;
}