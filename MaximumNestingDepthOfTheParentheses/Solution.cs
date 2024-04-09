namespace MaximumNestingDepthOfTheParentheses;

public class Solution {
    public int MaxDepth(string s)
    {
        int countOfBraces = 0, maxCountOfBraces = 0;
        
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                countOfBraces++;
                if (countOfBraces > maxCountOfBraces)
                    maxCountOfBraces = countOfBraces;
            }
            else if (s[i] == ')')
            {
                countOfBraces--;
            }
        }

        if (countOfBraces != 0) return 0;
        
        return maxCountOfBraces;
    }
}