using System.Linq;

namespace LeetCode.AddTwoNumbers
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }

        public override bool Equals(object obj)
        {
            var other = obj as ListNode;
            if (other == null) return false;
            if (next == null & other.next != null) return false;
            if (next != null & other.next == null) return false;
            if (next != null & other.next != null) return next.Equals(other.next);
            return val == other.val;
        }
    }

    public static class Extensions
    {
        public static ListNode GetListNode(this int[] values)
        {
            var firstNode = new ListNode(values.First());
            var currentNode = firstNode;
            foreach (int value in values.Skip(1))
            {
                currentNode.next = new ListNode(value);
                currentNode = currentNode.next;
            }
            return firstNode;
        }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var sum = l1.val + l2.val;
            var carry = sum >= 10;
            var val = sum % 10;
            var firstNode = new ListNode(val);
            var currentNode = firstNode;

            var next1 = l1.next;
            var next2 = l2.next;
            
            while (true)
            {
                if (next1 == null & next2 == null) break;
                sum = (next1?.val ?? 0) + (next2?.val ?? 0);
                if (carry) sum++;
                carry = sum >= 10;
                val = sum % 10;
                currentNode.next = new ListNode(val);
                currentNode = currentNode.next;
                next1 = next1?.next;
                next2 = next2?.next;
            }
            
            if (carry) currentNode.next = new ListNode(1);
            
            return firstNode;
        }
    }
}