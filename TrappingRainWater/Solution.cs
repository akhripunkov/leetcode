namespace TrappingRainWater;

public class Solution {
    public int Trap(int[] height)
    {
        int left = 0, right = height.Length - 1, maxleft = 0, maxRight = 0, water = 0;

        while (left < right)
        {
            if (height[left] <= height[right])
            {
                if (height[left] > maxleft)
                {
                    maxleft = height[left];
                }
                else
                {
                    water += maxleft - height[left];
                }

                left++;
            }
            else
            {
                if (height[right] > maxRight)
                {
                    maxRight = height[right];
                }
                else
                {
                    water += maxRight - height[right];
                }

                right--;
            }
        }

        return water;
        }
    }
