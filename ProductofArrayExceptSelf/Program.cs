// See https://aka.ms/new-console-template for more information

Console.WriteLine(ProductExceptSelf(new []{1,2,3,4}));
Console.WriteLine("Debug");

int[] ProductExceptSelf(int[] nums)
{
    var prefs = new int[nums.Length];
    var sufs = new int[nums.Length];
    prefs[0] = sufs[^1] = 1;


    for (int i = 2; i < nums.Length; i++)
    {
        prefs[i] = prefs[i - 1] * nums[i - 1];
    }
    
    for (int i = 2; i < nums.Length + 1; i++)
    {
        sufs[^i] = sufs[^(i - 1)] * nums[^(i - 1)];
    }

    var answer = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        answer[i] = prefs[i] * sufs[i];
    }

    return answer;
}