namespace LinkedListCycle
{
    internal class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }

        class LinkedListCycleExample
        {
            public static bool HasCycle(ListNode head)
            {
                if (head == null || head.next == null)
                    return false;

                ListNode slow = head;
                ListNode fast = head.next;

                while (slow != fast)
                {
                    if (fast == null || fast.next == null)
                        return false;

                    slow = slow.next;
                    fast = fast.next.next;
                }

                return true;
            }

            static void Main()
            {
                ListNode head = new ListNode(3);
                head.next = new ListNode(2);
                head.next.next = new ListNode(0);
                head.next.next.next = new ListNode(-4);
                head.next.next.next.next = head.next; // Döngü oluşturuldu

                bool hasCycle = HasCycle(head);
                Console.WriteLine($"Linked List has a cycle: {hasCycle}");
            }
        }
    }
}
