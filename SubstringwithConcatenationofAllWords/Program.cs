// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;

Console.WriteLine("Hello, World!");
var jsonResult = JsonConvert.SerializeObject(FindSubstring("wordgoodgoodgoodbestword", new []{"word","good","best","good"}));
Console.WriteLine(jsonResult);

IList<int> FindSubstring(string s, string[] words)
{
    var list = new List<int>();
    var queue = new Queue<string>();
    var hash = new HashSet<string>(words);
    var saved = new HashSet<string>(words);
    var step = words[0].Length;
    for (int i = 0; i < s.Length; i = i + step)
    {
        var substr = s.Substring(i, step);
        if (!words.Contains(substr))
        {
            queue.Clear();
            continue;
        }
        else
        {
            while (queue.Contains(substr))
            {
                queue.Dequeue();
            }
            
            queue.Enqueue(substr);
            

            if (queue.Count == words.Length)
            {
                list.Add(i - (words.Length - 1)*step);
            }
        }
    }

    return list;
}

IList<int> FindSubstringWithCopies(string s, string[] words)
{
    var list = new List<int>();
    var queue = new Queue<string>();

    var wordCount = new Dictionary<string, int>();
    foreach (var word in words)
    {
        if (wordCount.ContainsKey(word))
            wordCount[word]++;
        else
            wordCount[word] = 1;
    }

    var currentCount = new Dictionary<string, int>(); 
    int step = words[0].Length;

    for (int i = 0; i <= s.Length - step; i += step)
    {
        var substr = s.Substring(i, step);

        if (!wordCount.ContainsKey(substr))
        {
            queue.Clear();
            currentCount.Clear();
            continue;
        }

        if (currentCount.ContainsKey(substr) && currentCount[substr] == wordCount[substr])
        {
            while (queue.Peek() != substr)
            {
                var removed = queue.Dequeue();
                currentCount[removed]--;
            }
            queue.Dequeue(); 
        }

        queue.Enqueue(substr);

        if (currentCount.ContainsKey(substr))
            currentCount[substr]++;
        else
            currentCount[substr] = 1;

        if (queue.Count == words.Length)
        {
            list.Add(i - (words.Length - 1) * step);
            var removed = queue.Dequeue();
            currentCount[removed]--;
        }
    }

    return list;
}

IList<int> FindSubstringChatGpt(string s, string[] words)
{
    var list = new List<int>();
    var wordCount = new Dictionary<string, int>();
    foreach (var word in words)
    {
        if (wordCount.ContainsKey(word))
            wordCount[word]++;
        else
            wordCount[word] = 1;
    }

    int wordLength = words[0].Length;
    int totalWordsLength = words.Length * wordLength;
    
    for (int i = 0; i <= s.Length - totalWordsLength; i++)
    {
        var currentCount = new Dictionary<string, int>();
        int j = 0;
        
        while (j < words.Length)
        {
            var substr = s.Substring(i + j * wordLength, wordLength);
            if (!wordCount.ContainsKey(substr))
            {
                break;
            }
            
            if (currentCount.ContainsKey(substr))
                currentCount[substr]++;
            else
                currentCount[substr] = 1;
            
            if (currentCount[substr] > wordCount[substr])
            {
                break;
            }

            j++;
        }
        
        if (j == words.Length)
        {
            list.Add(i);
        }
    }

    return list;
}

IList<int> FindSubstringSlidingWindow(string s, string[] words)
{
    var list = new List<int>();
    int wordLength = words[0].Length;

    var wordCount = new Dictionary<string, int>();
    foreach (var word in words)
    {
        if (wordCount.ContainsKey(word))
            wordCount[word]++;
        else
            wordCount[word] = 1;
    }

    for (int i = 0; i < wordLength; i++)
    {
        int left = i;
        int count = 0; 
        var currentCount = new Dictionary<string, int>();

        for (int j = i; j <= s.Length - wordLength; j += wordLength)
        {
            var word = s.Substring(j, wordLength);

            if (wordCount.ContainsKey(word))
            {
                if (currentCount.ContainsKey(word))
                    currentCount[word]++;
                else
                    currentCount[word] = 1;

                count++;

                while (currentCount[word] > wordCount[word])
                {
                    var leftWord = s.Substring(left, wordLength);
                    currentCount[leftWord]--;
                    count--;
                    left += wordLength;
                }

                if (count == words.Length)
                {
                    list.Add(left);
                }
            }
            else
            {
                currentCount.Clear();
                count = 0;
                left = j + wordLength;
            }
        }
    }

    return list;
}