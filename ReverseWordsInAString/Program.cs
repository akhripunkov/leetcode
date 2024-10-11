// See https://aka.ms/new-console-template for more information

using System.Text;
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");
var s = "a good   example";
Console.WriteLine(ReverseWords(s));


string ReverseWords(string s)
{
    var array = RemoveExtraSpaces(s).Split(' ');
    if (array.Length == 0)
        return string.Empty;
    var sb = new StringBuilder();
    for (int i = 1; i < array.Length; i++)
    {
        sb.Append(array[^i]);
        sb.Append(' ');
    }
    sb.Append(array[0]);

    return sb.ToString();
}

string RemoveExtraSpaces(string input)
{
    return Regex.Replace(input.Trim(), @"\s+", " ");
}

string ReverseWordsBest(string s) {
    string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
    Array.Reverse(words);
    return string.Join(" ", words);
}