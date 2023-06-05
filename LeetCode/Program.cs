using System.Xml.Linq;

var firstList = new ListNode(1, new ListNode(2, new ListNode(3)));
var secondList = new ListNode(1, new ListNode(2, new ListNode(3)));

new Solution().MergeTwoLists(firstList,secondList);

//  Definition for singly-linked list.
public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int val = 0, ListNode next = null)
	{
		this.val = val;
		this.next = next;
	}
}

public class Solution
{
	public ListNode MergeTwoLists(ListNode list1, ListNode list2)
	{
		ListNode n = list1;
		while (n != null)
		{
			Console.Write(n.val + " ");
			n = n.next;
		}

		return null;
	}
}