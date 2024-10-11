// See https://aka.ms/new-console-template for more information


using Newtonsoft.Json;

var jsonResult = JsonConvert.SerializeObject(ThreeSum(new []{-1,0,1,2,-1,-4}));
Console.WriteLine(jsonResult);

IList<IList<int>> ThreeSum(int[] nums)
{
    var list = new List<IList<int>>();
    Array.Sort(nums);
    for (int i = 0; i < nums.Length - 2; i++)
    {
        if (i > 0 && nums[i] == nums[i - 1]) continue;
        int left = i + 1;
        int right = nums.Length - 1;
        while (left < right)
        {
            int sum = nums[i] + nums[left] + nums[right];


            if (sum == 0)
            {
                list.Add(new List<int>{nums[i], nums[left],nums[right]});
                while (left < right && nums[left] == nums[left + 1])
                {
                    left++;
                }
                while (left < right && nums[right] == nums[right - 1])
                {
                    right--;
                }

                left++;
                right--;
            }
            else if (sum < 0)
                left++;
            else
                right--;
        }
        
    }
    return list;
}