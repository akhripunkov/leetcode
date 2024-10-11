// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Console.WriteLine(HIndex(new []{100}));

int HIndex(int[] citations)
{
    var list = new List<int>(citations);
    list.Sort((a,b) => b.CompareTo(a));
    var h = 0;
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] >= i + 1)
        {
            h = i + 1;
        }
        else
        {
            break;
        }
    }

    return h;
}