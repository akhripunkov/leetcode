// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Console.WriteLine(RomanToInt("MCMXCIV"));

int RomanToInt(string s)
{
    var number = 0;
    for (int i = 0; i < s.Length; i++)
    {
        switch (s[i])
        {
            case 'I':
            {
                if (i < s.Length - 1 && (s[i+1] == 'V' || s[i+1] == 'X'))
                    number -= 1;
                else number += 1;
                break;
            }
            case 'V':
            {
                number += 5;
                break;
            }
            case 'X':
            {
                if (i < s.Length - 1 && (s[i + 1] == 'L' || s[i + 1] == 'C'))
                    number -= 10;
                else number += 10;
                break;
            }
            case 'L':
            {
                number += 50;
                break;
            }
            case 'C':
            {
                if (i < s.Length - 1 && (s[i + 1] == 'D' || s[i + 1] == 'M'))
                    number -= 100;
                else number += 100;
                break;
            }
            case 'D':
            {
                number += 500;
                break;
            }
            case 'M':
            {
                number += 1000;
                break;
            }
        }
    }
    return number;
}

int RomanToIntWithDict(string s)
{
    var romanMap = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    int number = 0;
    
    for (int i = 0; i < s.Length; i++)
    {
        // Если текущий символ меньше следующего, то вычитаем его значение, иначе добавляем
        if (i < s.Length - 1 && romanMap[s[i]] < romanMap[s[i + 1]])
            number -= romanMap[s[i]];
        else
            number += romanMap[s[i]];
    }
    
    return number;
}