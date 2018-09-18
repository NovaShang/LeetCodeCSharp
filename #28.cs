/*
#28. 实现strStr()

实现 strStr() 函数。

给定一个 haystack 字符串和一个 needle 字符串，在 haystack 字符串中找出 needle 字符串出现的第一个位置 (从0开始)。如果不存在，则返回  -1。

示例 1:

输入: haystack = "hello", needle = "ll"
输出: 2
示例 2:

输入: haystack = "aaaaa", needle = "bba"
输出: -1
*/

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if(needle.Length==0) return 0;
        for (int i = 0;  i < haystack.Length + 1 - needle.Length; i++)
            if (haystack[i] == needle[0])
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j]) break;
                    else if (j == needle.Length-1) return i;
                }
        return -1;
    }
}