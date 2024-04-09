using System.Text;

namespace MakeTheStringGreat;

public class Solution {
    public string MakeGood(string s)
    {
        var builder = new StringBuilder();
        int lastIndex = 0;
        for (int i = 0; i < s.Length ; i++)
        {
            if (builder.Length == 0)
            {
                builder.Append(s[i]);
            }
            else if (builder[lastIndex] == s[i] + 32 || builder[lastIndex] == s[i] - 32)
            {
                builder.Remove(lastIndex, 1);
            }
            else
            {
                builder.Append(s[i]);
            }
            
            lastIndex = builder.Length - 1;
        }

        return builder.ToString();
    }
}