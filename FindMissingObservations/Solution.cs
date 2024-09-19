namespace FindMissingObservations;

public class Solution
{
    public int[] MissingRolls(int[] rolls, int mean, int n)
    {
        int sum = mean * (rolls.Length + n) - rolls.Sum();
        double avg = (double)sum / n;
        if (avg < 1 || avg > 6)
        {
            return new int[0];
        }
        if (sum >= n && sum <= 6 * n)
        {
            var stack = new Stack<int>();
            
            while (n != 0)
            {
                int i = 1;
                while (i < 7)
                {
                    stack.Push(i);
                    sum -= i;
                    n--;
                    if (!(sum >= n && sum <= 6 * n))
                    {
                        stack.Pop();
                        sum += i;
                        n++;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return stack.ToArray();
        }
        else
        {
            return Array.Empty<int>();
        }
    }
}