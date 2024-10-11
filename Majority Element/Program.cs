// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int MajorityElement(int[] nums)
{

    var dict = new Dictionary<int, int>();
    foreach (var num in nums)
    {
        if (dict.ContainsKey(num))
        {
            dict[num]++;
        }
        else
        {
            dict[num] = 1;
        }
    }

    var res = dict.Where(kv => kv.Value == dict.Values.Max()).Select(kv => kv.Key).SingleOrDefault();
    
    return res;
}

int MajorityElementWithoutDict(int[] nums)
{
    var count = 0;
    var element = 0;
    
    for (int i = 0; i < nums.Length; i++)
    {
        if (count == 0)
        {
            element = nums[i];
            count++;
        }
        else
        {
            if (element == nums[i])
            if (element == nums[i])
            {
                count++;
            }
            else
            {
                count--;
            }
        }
    }
    
    return element;
}