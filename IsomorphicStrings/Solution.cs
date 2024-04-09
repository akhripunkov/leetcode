namespace IsomorphicStrings;

public class Solution {
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var dict = new Dictionary<char, char>();
        var dictT = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (dict.ContainsKey(s[i]) && (dict[s[i]] != t[i]))
            {
                return false;
            }

            if (dictT.ContainsKey(t[i]))
            {
                if (dictT[t[i]] != s[i])
                {
                    return false;
                }
            }
            else
            {
                dict.Add(s[i], t[i]);
                dictT.Add(t[i], s[i]);
            }
        }

        return true;
    }
}