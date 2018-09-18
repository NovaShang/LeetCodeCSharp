/*
#53. 最大子序和

给定一个整数数组 nums ，找到一个具有最大和的连续子数组（子数组最少包含一个元素），返回其最大和。

示例:

输入: [-2,1,-3,4,-1,2,1,-5,4],
输出: 6
解释: 连续子数组 [4,-1,2,1] 的和最大，为 6。
进阶:

如果你已经实现复杂度为 O(n) 的解法，尝试使用更为精妙的分治法求解。
*/

//这个版本时间复杂度o(n²)。要求o(n)。不能满足。
using System.Linq;

public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        var max=int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i; j < nums.Length; j++)
            {
                var sum=nums.Skip(i).Take(j-i+1).Sum(x=>x);
                if (sum>max) max=sum;
            }
        }
        return max;
    }
}