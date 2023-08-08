using System.IO;

namespace Answers.Easy
{
    public class Reverse : IRun
    {
        public static SinglyLinkedListNode reverse(SinglyLinkedListNode llist)
        {
            SinglyLinkedListNode next = null;
            SinglyLinkedListNode head = llist;
            SinglyLinkedListNode prev = null;

            while (head != null)
            {
                next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }

            return prev;
        }

        public void Run()
        {
            int tests = Convert.ToInt32(Console.ReadLine());

            for (int testsItr = 0; testsItr < tests; testsItr++)
            {
                SinglyLinkedList llist = new SinglyLinkedList();

                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                SinglyLinkedListNode llist1 = reverse(llist.head);
            }
        }
    }
}