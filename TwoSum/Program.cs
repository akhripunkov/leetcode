// See https://aka.ms/new-console-template for more information

using System.Text.Json.Serialization;
using Newtonsoft.Json;
using TwoSum;

var solution = new Solution();
var jsonResult = JsonConvert.SerializeObject(solution.TwoSum(new []{2,7,11,13}, 9));
Console.WriteLine(jsonResult);

