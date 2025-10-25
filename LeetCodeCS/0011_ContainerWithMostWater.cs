namespace LeetCodeCS;

public class _0011_ContainerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxArea = 0;
            int currentArea = 0;

            while (left < right)
            {
                int minH = height[left];
                if (height[left] > height[right]) minH = height[right];

                currentArea = (right - left) * minH;

                if (currentArea > maxArea) maxArea = currentArea;

                if (height[left] > height[right]) right--;
                else left++;
            }
            return maxArea;
        }
    }
}
