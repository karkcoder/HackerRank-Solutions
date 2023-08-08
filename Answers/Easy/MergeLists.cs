using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers.Easy
{
    public class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            data = nodeData;
            next = null;
        }
    }

    public class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            head = null;
            tail = null;
        }

        public void InsertNode(int nodeData)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.next = node;
            }

            tail = node;
        }
    }

    public class MergeLists : IRun
    {
        public void Run()
        {
            SinglyLinkedList llist1 = new SinglyLinkedList();

            int llist1Count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llist1Count; i++)
            {
                int llist1Item = Convert.ToInt32(Console.ReadLine());
                llist1.InsertNode(llist1Item);
            }

            SinglyLinkedList llist2 = new SinglyLinkedList();

            int llist2Count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llist2Count; i++)
            {
                int llist2Item = Convert.ToInt32(Console.ReadLine());
                llist2.InsertNode(llist2Item);
            }

            SinglyLinkedListNode llist3 = mergeLists(llist1.head, llist2.head);

            PrintSinglyLinkedList(llist3, " ");
            Console.WriteLine();
        }

        private static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2) ///1,2,3    2,3,4
        {
            SinglyLinkedListNode prev = null;
            SinglyLinkedListNode next = null;
            SinglyLinkedListNode x1 = head1;
            SinglyLinkedListNode x2 = head2;

            while (x1 != null && x2 != null)
            {
                if (x1.data <= x2.data)
                {
                    next = x1.next;
                    x1.next = prev;
                    prev = x1;
                    x1 = next;
                }
                else
                {
                    next = x2.next;
                    x2.next = prev;
                    prev = x2;
                    x2 = next;
                }
            }
            while (x1 != null)
            {
                next = x1.next;
                x1.next = prev;
                prev = x1;
                x1 = next;
            }

            while (x2 != null)
            {
                next = x2.next;
                x2.next = prev;
                prev = x2;
                x2 = next;
            }

            return prev;
        }

        private static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
        {
            Console.WriteLine("");
            while (node != null)
            {
                Console.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    Console.Write(sep);
                }
            }
        }
    }
}