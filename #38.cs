/*

#38. 报数

报数序列是指一个整照其中的整数的顺序进数序列，按行报数，得到下一个数。其前五项如下：

1.     1
2.     11
3.     21
4.     1211
5.     111221
1 被读作  "one 1"  ("一个一") , 即 11。
11 被读作 "two 1s" ("两个一"）, 即 21。
21 被读作 "one 2",  "one 1" （"一个二" ,  "一个一") , 即 1211。

给定一个正整数 n（1 ≤ n ≤ 30），输出报数序列的第 n 项。

注意：整数顺序将表示为一个字符串。

 

示例 1:

输入: 1
输出: "1"
示例 2:

输入: 4
输出: "1211"

*/
using System.Collections.Generic;

public class Solution
{
    public string CountAndSay(int n)
    {
        if(n==1) return "1";
        return GetNext(CountAndSay(n-1));

    }

    public string GetNext(string s)
    {
        var r = new List<string>();
        var j = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != s[j]){
                r.Add((i - j).ToString() + s[j]);
                j=i;
            }
            if (i == s.Length - 1)
                r.Add((i - j + 1).ToString() + s[j]);
        }
        return string.Concat(r);
    }
}