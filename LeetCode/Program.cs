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
	public ListNode MergeTwoLists(ListNode list1, ListNode list2)
	{
		var intList = new List<int>(15);

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

		//for (int i = 0; i < intList.Count; i++)
		//{
		//	if (i == counter)
		//		break;
		//	node.val = intList[i];
		//	node.next = new ListNode();
		//	node = node.next;
		//}

		node.val = intList[0];
		node.next = new ListNode(intList[1]);
		node.next.next = new ListNode(intList[2]);
		node.next.next.next = new ListNode(intList[3]);
		node.next.next.next.next = new ListNode(intList[4]);
		node.next.next.next.next.next = new ListNode(intList[5]);
		//while (node!= null)
		//{
		//          Console.WriteLine(node.val);
		//          node= node.next;
		//}

		return node;
	}
}