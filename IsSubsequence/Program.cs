// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

bool IsSubsequence(string s, string t) {
    if (s.Length == 0) return true;
    int j = 0;
    for (int i = 0; i < t.Length && j < s.Length; i++)
    {
        if (s[j] == t[i])
        {
            j++;
        }
    }

    return j == s.Length;
}

bool IsSubsequence2(string s, string t) {
    int i = 0;
    int j = 0;
    while (j < s.Length && i < t.Length)
    {
        if (s[j] == t[i])
        {
            i++;
            j++;
        }
        else
        {
            i++;
        }
    }

    return j == s.Length;
}