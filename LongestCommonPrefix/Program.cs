// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

string LongestCommonPrefix(string[] strs)
{
    var tempword = strs[0];
    var minLen = tempword.Length;
    for (int i = 1; i < strs.Length; i++)
    {
        minLen = Math.Min(tempword.Length, strs[i].Length);
        tempword = tempword[..minLen];
        while (!strs[i][..minLen].Equals(tempword[..minLen]))
        {
            minLen--;
            if (minLen == 0)
                return string.Empty;
            tempword = tempword[..minLen];
        }
    }

    return tempword;
}