// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

void Rotate(int[] nums, int k)
{
    var newK = k % nums.Length;
    var arr = new int[newK];
    for (int i = 1; i < arr.Length + 1; i++)
    {
        arr[^i] = nums[^i];
    }

    for (int i = 1; i < nums.Length - newK + 1; i++)
    {
        nums[^i] = nums[^(i + newK)];
    }
    
    for (int i = 0; i < arr.Length; i++)
    {
        nums[i] = arr[i];
    }
    
}

