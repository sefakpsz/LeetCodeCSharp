using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

var firstList = new ListNode(1, new ListNode(2, new ListNode(4)));
var secondList = new ListNode(1, new ListNode(3, new ListNode(4)));

var result = new Solution().MergeTwoLists(firstList, secondList);

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
		var intList = new int[50];
		var intList2 = new int[50];

		var node = new ListNode();
		node.val = list1.val;
		node.next = new ListNode(list1.next.val);

		short counter = 0;
		while (list1 != null)
		{
			list1 = list1.next;
			
			counter++;
		}

		counter = 0;

		while (list2 != null)
		{
			node.val = list2.val;
			node = node.next;
			list2 = list2.next;
			counter++;
		}

		while (node != null)
		{
			Console.WriteLine(node.val);

		}

		var mergedList = new int[100];

		for (int i = 0; i < 100; i++)
		{
			mergedList[i] = intList[i];
			mergedList[i + 1] = intList2[i];
		}

		var k = 0;
		while (true)
		{
			Console.WriteLine(mergedList[k]);
			k++;
			if (k == mergedList.Length)
				break;
		}

		//var listNode = new ListNode();
		//while (true)
		//{

		//}

		return null;
	}
}