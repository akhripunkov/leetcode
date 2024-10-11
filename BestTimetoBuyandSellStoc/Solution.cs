namespace BestTimetoBuyandSellStoc;
// Пример с мемоизацией, для уменьшения времени
public class Solution {
    public int[] memo;

    public int MaxProfit(int[] prices)
    {
        var res = MaxProfRec(0, prices);

        return res;
    }

    public int MaxProfRec(int leftI, int[] prices)
    {
        memo = new int[prices.Length];
        for (int i = 0; i < memo.Length; i++)
        {
            memo[i] = -1;
        }
        return MaxProfitHelper(leftI, prices);
    }

    // Вспомогательная рекурсивная функция с мемоизацией
    private int MaxProfitHelper(int leftI, int[] prices)
    {
        if (leftI >= prices.Length - 1)
        {
            return 0;
        }

        if (memo[leftI] != -1)
        {
            return memo[leftI];
        }

        int profit = 0;

        for (int i = leftI + 1; i < prices.Length; i++)
        {
            if (prices[i] > prices[leftI])
            {
                int currentProfit = prices[i] - prices[leftI] + MaxProfitHelper(i + 1, prices);
                profit = Math.Max(profit, currentProfit);
            }
        }

        int skipProfit = MaxProfitHelper(leftI + 1, prices);

        memo[leftI] = Math.Max(profit, skipProfit);

        return memo[leftI];
    }
}