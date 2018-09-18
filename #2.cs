/* 

#2. 两数相加

给定两个非空链表来表示两个非负整数。位数按照逆序方式存储，它们的每个节点只存储单个数字。将两数相加返回一个新的链表。

你可以假设除了数字 0 之外，这两个数字都不会以零开头。

示例：

输入：(2 -> 4 -> 3) + (5 -> 6 -> 4)
输出：7 -> 0 -> 8
原因：342 + 465 = 807 

*/

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var result = new ListNode(0);
        ListNode pos1 = l1, pos2 = l2, pos3 = result;
        var over = 0;
        while (pos1 != null || pos2 != null)
        {
            var sum = (pos1?.val ?? 0) + (pos2?.val ?? 0) + over;
            if (sum > 10)
            {
                over = 1;
                sum -= 10;
            }
            else
                over = 0;
            pos3.next = new ListNode(sum);
            pos3 = pos3?.next;
            pos1 = pos1?.next;
            pos2 = pos2?.next;
        }
        if(over!=0) pos3.next=new ListNode(1);
        return result.next;
    }
}