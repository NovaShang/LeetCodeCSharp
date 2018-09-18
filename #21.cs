/*
#21. 合并两个有序链表

将两个有序链表合并为一个新的有序链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 

示例：

输入：1->2->4, 1->3->4
输出：1->1->2->3->4->4
 */


public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public class Solution
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        var l3 = new ListNode(0);
        var result=l3;
        while (l1 != null && l2 != null)
        {
            if (l1.val > l2.val)
            {
                l3.next = new ListNode(l2.val);
                l2 = l2.next;
            }
            else
            {
                l3.next = new ListNode(l1.val);
                l1 = l1.next;
            }
            l3 = l3.next;
        }
        if (l1 != null) l3.next = l1;
        else l3.next = l2;

        return result.next;

    }
}