/*

#67. 二进制求和

给定两个二进制字符串，返回他们的和（用二进制表示）。

输入为非空字符串且只包含数字 1 和 0。

示例 1:

输入: a = "11", b = "1"
输出: "100"
示例 2:

输入: a = "1010", b = "1011"
输出: "10101"

*/

using System.Text;
public class Solution
{
    public string AddBinary(string a, string b)
    {
        var over = false;
        var sb = new StringBuilder();
        if (a.Length > b.Length) b = b.PadLeft(a.Length, '0');
        else a = a.PadLeft(b.Length, '0');
        for (int i = a.Length - 1; i >= 0; i--)
        {
            var bitA = a[i] == '1';
            var bitB = b[i] == '1';
            var sum = bitA ^ bitB ^ over;
            over = (bitA && bitB) || ((bitA ^ bitB) & over);
            sb.Insert(0, sum ? '1' : '0');
        }
        if (over) sb.Insert(0, '1');
        return sb.ToString();
    }
}