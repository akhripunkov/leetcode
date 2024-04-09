namespace LengthOfLastWord;

public class Solution {
    public int LengthOfLastWord(string s)
    {
        var arr = s.Trim().Split(' ');
        return arr[^1].Length;
    }
}