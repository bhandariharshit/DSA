using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class LinkedListT
    {
        public LinkedListNode head = null;

        public LinkedListT(int val)
        {
            head = new LinkedListNode(val);
        }

        public void AddNode(int val)
        {
            if (head == null)
                head = new LinkedListNode(val);
            else
            {
                LinkedListNode linkedListNode = new LinkedListNode(val);
                linkedListNode.Next = head;
                head = linkedListNode;
            }
        }
        public void PrintReverse(LinkedListNode Node)
        {
            if (Node == null)
                return;

            PrintReverse(Node.Next);
            Console.Write(Node.value);

        }

        public void ReverseLinkedList(LinkedListNode node)
        {
            if (node == null)
                return;
            if (node.Next == null)
            {
                head = node;
                return;
            }

            ReverseLinkedList(node.Next);
            node.Next.Next = node;
            node.Next = null;
        }

        public void ReverseLinkedListI(LinkedListNode node, LinkedListNode prev = null)
        {
            if (node == null)
                return;
            if (node.Next == null)
            {
                head = node;
                head.Next = prev;
                return;
            }

            LinkedListNode newNode = node.Next;
            node.Next = prev;
            ReverseLinkedListI(newNode, node);

        }

        public bool IsPalindromeList(LinkedListNode node)
        {
            if (node == null)
                return false;

            LinkedListNode slow = node;
            LinkedListNode fast = node;
            Stack<int> stack = new Stack<int>();
            int count = 0;
            int size = 0;

            while(slow != null)
            {
                if(fast != null)
                {
                    fast = fast.Next.Next;
                    stack.Push(slow.value);
                    count++;
                }
                else
                {
                    int val = stack.Pop();
                    if(val != slow.value)
                    {
                        return false;
                    }
                }
                slow = slow.Next;                
            }
            return true;
        }

        public int SizeOfLinkedList(LinkedListNode node)
        {
            if (node == null)
                return 0;

            int n = 0;

            while (node != null)
            {
                n++;
                node = node.Next;
            }
            return n;
        }

        /// <summary>
        /// Program to remove nth node from end of the linked list
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public LinkedListNode RemoveNthFromEnd(LinkedListNode head, int n)
        {
            LinkedListNode slow = head;
            LinkedListNode fast = head;

            for (int i = 0; i < n; i++)
            {
                if (fast.Next == null)
                {

                    // If count = N i.e. delete the head node 
                    if (i == n - 1)
                        head = head.Next;
                    return head;
                }
                fast = fast.Next;
            }

            while (fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            slow.Next = slow.Next.Next;

            return head;

        }

        /// <summary>
        /// Remove Duplicates from Sorted List.
        /// </summary>
        /// <param name="head">The head.</param>
        /// <returns></returns>
        public LinkedListNode DeleteDuplicates(LinkedListNode head)
        {
            LinkedListNode list = head;

            while (list.Next != null)
            {
                if (list.value == list.Next.value)
                {
                    list.Next = list.Next.Next;
                }
                else
                {
                    list = list.Next;
                }
            }

            return head;

        }
    }
}
