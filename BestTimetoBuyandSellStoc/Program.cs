var arr = new[] { 2, 1, 4, 5, 2, 9, 7 };
Console.WriteLine(MaxProfit122(arr));



int MaxProfit(int[] prices)
{
    var profit = 0;
    if (prices.Length == 0) return 0;
    int min = prices[0];
    int max = prices[0];
    for (int i = 0; i < prices.Length; i++)
    {
        if (prices[i] > max)
        {
            max = prices[i];
            profit = max - min > profit ? max - min : profit;
        }
        if (prices[i] < min)
        {
            min = prices[i];
            max = prices[i];
        }
    }

    return profit;
}

int MaxProfit122(int[] prices)
{
    var res = MaxProfRec(0, prices);

    return res;
}

int MaxProfRec(int leftI, int[] prices)
{
    var profit = 0;
    int left = prices[leftI];
    int right = prices[leftI];
    for (int i = leftI; i < prices.Length; i++)
    {
        if (prices[i] > right)
        {
            right = prices[i];
            profit = right - left > profit ? right - left + MaxProfRec(i+1, prices): profit + MaxProfRec(i+1, prices);
        }
        if (prices[i] < left)
        {
            left = prices[i];
            right = prices[i];
        }
    }

    return profit;
}

int MaxProfRecGpt(int leftI, int[] prices)
{
    if (leftI >= prices.Length - 1)
    {
        return 0;
    }

    int profit = 0;

    for (int i = leftI + 1; i < prices.Length; i++)
    {
        if (prices[i] > prices[leftI])
        {
            int currentProfit = prices[i] - prices[leftI] + MaxProfRec(i + 1, prices);
            profit = Math.Max(profit, currentProfit);
        }
    }
    int skipProfit = MaxProfRec(leftI + 1, prices);

    return Math.Max(profit, skipProfit);
}

int MaxProfit122Gpt(int[] prices)
{
    int maxProfit = 0;

    for (int i = 1; i < prices.Length; i++)
    {
        if (prices[i] > prices[i - 1])
        {
            maxProfit += prices[i] - prices[i - 1];
        }
    }

    return maxProfit;
}
