using System.Text;

namespace ReverseInteger;

public class Solution {
    public int ReverseWithoutStringConversion(int x)
    {
        if (x == 0)
        {
            return 0;
        }
        
        //bool sign = x > 0 ? true : false;
        long res = 0;
        long abs = x;
        while (abs % 10 == 0 && abs != 0)
        {
            abs /= 10;
        }

        while (abs != 0)
        {
            res = res * 10 + abs % 10;
            abs /= 10;
        }
        if (res is >= int.MaxValue or <= int.MinValue) 
            return 0;
        //return sign ? (int)res : -(int)res;

        return (int)res;
    }
    
    public int Reverse(int x)
    {
        if (x == 0)
        {
            return 0;
        }
        
        bool sign = x > 0 ? true : false;
        var str = x.ToString();
        if (!sign)
            str = str.Substring(1, str.Length - 1);
        var array = str.ToCharArray();
        Array.Reverse(array);
        var newStr = new string(array);
        var builder = new StringBuilder();
        if (!sign)
            builder.Append("-");
        builder.Append(newStr);
        long result = Convert.ToInt64(builder.ToString());
        if (result > int.MaxValue || result < int.MinValue)
            return 0;

        return (int)result;
    }
    
    public int ReverseFastest(int x) {
        bool positive = x >= 0;

        var str = positive ? x.ToString() : x.ToString().Split('-')[1];

        var builder = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            builder.Insert(0, str[i]);
        }

        if (!int.TryParse(builder.ToString(), out var value))
        {
            return 0;
        }

        return positive ? value : value * -1;
    }
}
