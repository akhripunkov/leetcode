// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));

bool IsPalindrome(string s)
{
    var clean = RemoveNonAlphabetChars(s);
    var reversed = Reverse(clean);
    return clean.ToLower().Equals(reversed.ToLower());
}

string RemoveNonAlphabetChars(string s)
{
    return Regex.Replace(s.Trim(), "[^a-zA-Z0-9]+", "");
}

string Reverse(string s)
{
    var array = s.ToCharArray();
    Array.Reverse(array);
    return new string(array);
}