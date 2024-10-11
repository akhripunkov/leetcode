// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int MaxArea(int[] height) {
    var left = 0;
    var right = height.Length - 1;
    var area = 0; 
    var temp = 0;
    var min = 0;
    var dist = 0;
    while (left < right)
    {
        if (height[left] < height[right])
        {
            min = height[left];
            dist = right - left;
            left++;
        }
        else
        {
            min = height[right];
            dist = right - left;
            right--;
        }

        temp = min * dist;
        area = temp > area ? temp : area; 
    }
        
    return area;
}