// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int StrStr(string haystack, string needle) {
    for (int i = 0; i < haystack.Length; i++)
    {
        if (needle[0] == haystack[i])
        {
            if (needle.Length > haystack.Length - i)
                return -1;
            if (needle.Equals(haystack.Substring(i, needle.Length)))
                return i;
        }
    }

    return -1;
}