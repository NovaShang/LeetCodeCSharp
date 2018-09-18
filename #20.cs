/*
#20. 有效的括号

给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串，判断字符串是否有效。

有效字符串需满足：

左括号必须用相同类型的右括号闭合。
左括号必须以正确的顺序闭合。
注意空字符串可被认为是有效字符串。

示例 1:

输入: "()"
输出: true
示例 2:

输入: "()[]{}"
输出: true
示例 3:

输入: "(]"
输出: false
示例 4:

输入: "([)]"
输出: false
示例 5:

输入: "{[]}"
输出: true
 */
using System.Collections.Generic;

public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case '(':
                case '[':
                case '{':
                    stack.Push(s[i]);
                    break;
                case ')':
                    if (stack.Count == 0 || stack.Pop() != '(') return false;
                    break;
                case ']':
                    if (stack.Count == 0 || stack.Pop() != '[') return false;
                    break;
                case '}':
                    if (stack.Count == 0 || stack.Pop() != '{') return false;
                    break;
                default:
                    break;
            }
        }
        if (stack.Count != 0) return false;
        return true;
    }
}