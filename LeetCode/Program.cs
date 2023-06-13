using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

var firstList = new ListNode(1, new ListNode(2, new ListNode(4)));
var secondList = new ListNode(1, new ListNode(3, new ListNode(4)));

Console.WriteLine(new Solution().MergeTwoLists(firstList, secondList));

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
	static void push(ref ListNode head_ref, int new_key, bool next)
	{
		var new_node = new ListNode();

		new_node.val = new_key;

		new_node.next = head_ref;

		head_ref = new_node;
	}

	public ListNode MergeTwoLists(ListNode list1, ListNode list2)
	{
		var intList = new List<int>();

		short counter = 0;
		while (list1 != null)
		{
			intList.Add(list1.val);
			list1 = list1.next;
			counter++;
		}

		while (list2 != null)
		{
			intList.Add(list2.val);
			list2 = list2.next;
			counter++;
		}

		intList.Sort();

		var node = new ListNode();

		for (int i = intList.Count - 1; i >= 0; i--)
		{
			push(ref node, intList[i], i != 0);
		}

		while (node != null)
		{
			Console.WriteLine(node.val);
			node = node.next;
		}

		return node;
	}
}