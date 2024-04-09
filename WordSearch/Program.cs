// See https://aka.ms/new-console-template for more information

using WordSearch;



var sol = new Solution();

char[][] cells = new char[][] {
    new char[] { 'A', 'B', 'C', 'E' },
    new char[] { 'S', 'F', 'C', 'S' },
    new char[] { 'A', 'D', 'E', 'E' }
};
var word = "ABCCED";
Console.WriteLine(sol.Exist(cells, word));