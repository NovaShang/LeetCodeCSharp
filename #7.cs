/*
#7. 反转整数

给定一个 32 位有符号整数，将整数中的数字进行反转。

示例 1:

输入: 123
输出: 321
 示例 2:

输入: -123
输出: -321
示例 3:

输入: 120
输出: 21
注意:

假设我们的环境只能存储 32 位有符号整数，其数值范围是 [−231,  231 − 1]。根据这个假设，如果反转后的整数溢出，则返回 0

*/
using System;
using System.Linq;
public class Solution
{
    public int Reverse(int x)
    {
        if (x == int.MinValue) return 0;
        var str = Math.Abs(x).ToString();
        var inverseStr = new string(str.Reverse().ToArray());
        var pos = x >= 0;
        var value = long.Parse(inverseStr);
        if ((pos && value > int.MaxValue) || ((!pos) && -value < int.MinValue))
            return 0;
        return pos ? (int)value : -(int)value;
    }
}