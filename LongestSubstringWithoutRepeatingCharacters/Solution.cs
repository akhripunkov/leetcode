namespace LongestSubstringWithoutRepeatingCharacters;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var dict = new Dictionary<char,int>();
        int result = 0;
        int currentCount = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (dict.ContainsKey(s[i]))
            {
                var temp = dict[s[i]];
                dict.Clear();
                dict[s[temp + 1]] = temp + 1;
                i = temp + 1;
                if (result < currentCount) result = currentCount;
                currentCount = 1;
            }
            else
            {
                dict[s[i]] = i;
                currentCount++;
            }
        }
        if (result < currentCount) result = currentCount;
        
        return result;
    }
    
    
    public int LengthOfLongestSubstringBest(string s)
    {
        var queue = new Queue<char>();
        var max = 0;

        foreach (var symbol in s)
        {
            while (queue.Contains(symbol))
                queue.Dequeue();
            
            queue.Enqueue(symbol);
            max = max > queue.Count ? max : queue.Count;
        }
        
        return max;
    }
    
    public int LengthOfLongestSubstring11(string s) {
        
        Queue<char> queue = new Queue<char>();
        int max = 0;

        foreach ( char letter in s )
        {
            while ( queue.Contains( letter ) )
            {
                queue.Dequeue();
            }

            queue.Enqueue( letter );

            max = Math.Max( max, queue.Count );
        }

        return max;
    }
}




