using System;

namespace Data_Structures
{
    public class SinglyLinkedList
    {
        SinglyLinkedListNode node;

        static string PrintLinkedList(SinglyLinkedList list)
        {
            SinglyLinkedListNode head = list.node;

            string s = string.Empty;

            while (head != null)
            {
                Console.WriteLine(head.data);
                s = string.Concat(s, "  ", head.data);
                head = head.next;
            }

            return s;
        }

        static void PrintLinkedListReverse(SinglyLinkedListNode head)
        {
            if (head == null) return;
            if (head.next == null) Console.WriteLine(head.data);

            PrintLinkedListReverse(head.next);
            Console.WriteLine(head.data);
        }

        static SinglyLinkedListNode AddNodeToLast(SinglyLinkedList list, SinglyLinkedListNode node)
        {
            SinglyLinkedListNode head = list.node;

            if (head == null)
            {
                list.node = node;
                return node;
            }    

            while(head.next!=null)
            {
                head = head.next;
            }
            head.next = node;

            return list.node;
        }

        static SinglyLinkedListNode AddNodeToFront(SinglyLinkedList list, SinglyLinkedListNode node)
        {
            node.next = list.node;
            list.node = node;

            return list.node;
        }

        /// <summary>
        /// Delete a node
        /// </summary>
        /// <param name="head"></param>
        /// <param name="position">This will be 0 index based</param>
        /// <returns></returns>
        static SinglyLinkedListNode DeleteNode(SinglyLinkedListNode head, int position)
        {
            if (head == null) return head;
            if (position == 0) return head.next;

            SinglyLinkedListNode top = head;

            while (top != null && position > 1)
            {
                top = top.next;
                position--;
            }

            if (top != null && top.next != null)
                top.next = top.next.next;

            return head;
        }

        static SinglyLinkedListNode ReverseSinglyLinkedList(SinglyLinkedListNode head)
        {
            if (head.next == null) return head;

            SinglyLinkedListNode behind = null, current = head, ahead = null;

            while (current.next != null)
            {
                ahead = current.next;  
                current.next = behind; 
                behind = current;      
                current = ahead;       
            }

            current.next = behind;

            return current;
        }

        static bool AreTheseSinglyLinkedListsEqual(SinglyLinkedListNode one, SinglyLinkedListNode two)
        {
            if (one == null && two == null) return true;

            while (one != null && two != null)
            {
                if (one.data == two.data)
                {
                    one = one.next;
                    two = two.next;
                }
                else
                {
                    return false;
                }
            }

            if (one == null && two == null) 
                return true;
            else
                return false;
        }

        // 1 2 3 4 5 6 null
        static int GetLastNthNode(SinglyLinkedListNode head, int n)
        {
            if(head.next == null)

        }

    }

    public class SinglyLinkedListNode
    {
        internal SinglyLinkedListNode next;
        internal int data;
    }

}
