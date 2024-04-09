namespace TimeNeededToBuyTickets;

public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k)
    {
        int seconds = 0;
        while (tickets[k] != 0)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] != 0)
                {
                    tickets[i]--;
                    seconds++;
                }
                
                if (tickets[k] == 0)
                {
                    break;
                }
            }
        }

        return seconds;
    }
}