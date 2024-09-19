using System.Collections.Concurrent;

namespace LeetCodeTemplate;

public class Solution
{
    public string[] UncommonFromSentences(string s1, string s2)
    {
        var s1words = s1.Split(' ');
        var s2words = s2.Split(' ');
        var dict = new Dictionary<string,int>();
        foreach (var i in s1words) 
        {
            if (dict.ContainsKey(i))
                dict[i]++;
            else
            {
                dict[i] = 1;
            }
        };
        foreach (var i in s2words) 
        {
            if (dict.ContainsKey(i))
                dict[i]++;
            else
            {
                dict[i] = 1;
            }
        };

        var result = new List<string>();
        foreach (var kvp in dict)   
        {
            if (kvp.Value == 1)
                result.Add(kvp.Key);
        }

        var res = dict.Where(e => e.Value == 1).Select(e => e.Key).ToArray();
        return result.ToArray();
    }

    public string[] UncommonFromSentencesParralel(string s1, string s2)
    {
        var s1words = s1.Split(' ');
        var s2words = s2.Split(' ');
        var dict = new ConcurrentDictionary<string, int>();

        // Параллельно обрабатываем два набора слов
        Parallel.ForEach(s1words, word =>
        {
            dict.AddOrUpdate(word, 1, (key, oldValue) => oldValue + 1);
        });

        Parallel.ForEach(s2words, word =>
        {
            dict.AddOrUpdate(word, 1, (key, oldValue) => oldValue + 1);
        });

        // Собираем результат
        var result = dict.Where(kvp => kvp.Value == 1)
            .Select(kvp => kvp.Key)
            .ToArray();

        return result;
    }
}