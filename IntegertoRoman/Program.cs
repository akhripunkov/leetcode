// See https://aka.ms/new-console-template for more information

using System.Text;

Console.WriteLine(IntToRoman(1994));

string IntToRoman(int num)
{
    var sb = new StringBuilder();
    var snum = num.ToString();

    for (int i = 1; i < snum.Length + 1; i++)
    {
        if (i == 1)
        {
            if (snum[^i] == '1') sb.Append("I");
            else if (snum[^i] == '2') sb.Append("II");
            else if (snum[^i] == '3') sb.Append("III");
            else if (snum[^i] == '4') sb.Append("VI");
            else if (snum[^i] == '5') sb.Append("V");
            else if (snum[^i] == '6') sb.Append("IV");
            else if (snum[^i] == '7') sb.Append("IIV");
            else if (snum[^i] == '8') sb.Append("IIIV");
            else if (snum[^i] == '9') sb.Append("XI");
            else if (snum[^i] == '0') continue;
        }
        if (i == 2)
        {
            if (snum[^i] == '1') sb.Append("X");
            else if (snum[^i] == '2') sb.Append("XX");
            else if (snum[^i] == '3') sb.Append("XXX");
            else if (snum[^i] == '4') sb.Append("LX");
            else if (snum[^i] == '5') sb.Append("L");
            else if (snum[^i] == '6') sb.Append("XL");
            else if (snum[^i] == '7') sb.Append("XXL");
            else if (snum[^i] == '8') sb.Append("XXXL");
            else if (snum[^i] == '9') sb.Append("CX");
            else if (snum[^i] == '0') continue;
        }
        if (i == 3)
        {
            if (snum[^i] == '1') sb.Append("C");
            else if (snum[^i] == '2') sb.Append("CC");
            else if (snum[^i] == '3') sb.Append("CCC");
            else if (snum[^i] == '4') sb.Append("DC");
            else if (snum[^i] == '5') sb.Append("D");
            else if (snum[^i] == '6') sb.Append("CD");
            else if (snum[^i] == '7') sb.Append("CCD");
            else if (snum[^i] == '8') sb.Append("CCCD");
            else if (snum[^i] == '9') sb.Append("MC");
            else if (snum[^i] == '0') continue;
        }
        if (i == 4)
        {
            if (snum[^i] == '1') sb.Append("M");
            else if (snum[^i] == '2') sb.Append("MM");
            else if (snum[^i] == '3') sb.Append("MMM");
            else  continue;
        }
    }

    var s = sb.ToString();
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    
    return new string(charArray);
}