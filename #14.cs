/*
#14. 最长公共前缀

编写一个函数来查找字符串数组中的最长公共前缀。

如果不存在公共前缀，返回空字符串 ""。

示例 1:

输入: ["flower","flow","flight"]
输出: "fl"
示例 2:

输入: ["dog","racecar","car"]
输出: ""
解释: 输入不存在公共前缀。
说明:

所有输入只包含小写字母 a-z 。
 */
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if(strs.Length==0) return "";
        var result = "";
        var i = 0;
        while (true)
        {
            if (i == strs[0].Length) return result;
            var c = strs[0][i];
            for(int j=0;j<strs.Length;j++)
                if (i == strs[j].Length || strs[j][i] != c) return result;
            result += c;
            i++;
        }
        return result;
    }
}