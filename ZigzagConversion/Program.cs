// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

string Convert(string s, int numRows)
{
    if (numRows == 1)
        return s;

    var goDown = false;
    var currentRow = 0;
    var list = new List<string>(new string[Math.Min(numRows, s.Length)]);
    foreach (var c in s)
    {
        list[currentRow] += c;

        if (currentRow == 0 || currentRow == numRows - 1)
        {
            goDown = !goDown;
        }

        currentRow += goDown ? 1 : -1;
    }

    var result = string.Join("", list);
    return result;
}