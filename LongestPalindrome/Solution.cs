namespace LongestPalindrome;

public class Solution {
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return "";
        }

        string result = "";
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i + 1; j <= s.Length; j++)
            {
                string sub = s.Substring(i, j - i);
                if (IsPalindrome(sub) && sub.Length > result.Length)
                {
                    result = sub;
                }
            }
        }

        return result;
    }

    private bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}