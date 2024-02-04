namespace MergeTwoLinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // İlk bağlı listeyi oluştur
            ListNode list1 = new ListNode(1);
            list1.next = new ListNode(2);
            list1.next.next = new ListNode(4);

            // İkinci bağlı listeyi oluştur
            ListNode list2 = new ListNode(1);
            list2.next = new ListNode(3);
            list2.next.next = new ListNode(5);

            Console.WriteLine("List 1:");
            PrintList(list1);

            Console.WriteLine("List 2:");
            PrintList(list2);

            // İki bağlı listeyi birleştir
            ListNode mergedList = MergeTwoLists(list1, list2);

            Console.WriteLine("\nMerged List:");
            PrintList(mergedList);
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;

            if (l1.val < l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }
        }

        public static void PrintList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
            Console.WriteLine();
        }
    }

    internal class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}
