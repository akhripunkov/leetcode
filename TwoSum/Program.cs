// See https://aka.ms/new-console-template for more information

using System.Text.Json.Serialization;
using Newtonsoft.Json;
using TwoSum;

var solution = new Solution();
var jsonResult = JsonConvert.SerializeObject(solution.TwoSum(new []{2,7,11,13}, 9));
Console.WriteLine(jsonResult);

jsonResult = JsonConvert.SerializeObject(TwoSum(new []{2,7,11,13}, 9));
Console.WriteLine(jsonResult);

int[] TwoSum(int[] numbers, int target) {
    int i = 0;
    int j = numbers.Length - 1;
    while (i < j)
    {
        var sum = numbers[i] + numbers[j]; 
        if (sum > target)
        {
            j--;
        }
        else if (sum < target)
        {
            i++;
        }
        else
        {
            return new int[2] {i+1, j+1};
        }
    }

    return new int[2] {0, 0};
}