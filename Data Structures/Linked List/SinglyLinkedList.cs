namespace Data_Structures
{
    using System;

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

        static int GetLastNthNode(SinglyLinkedListNode head, int n)
        {
            SinglyLinkedListNode node1, node2;
            node1 = head;

            while(n-- > 0)
            {
                node1 = node1.next;
            }

            node2 = head;

            while (node1.next != null)
            {
                node1 = node1.next;
                node2 = node2.next;
            }

            return node2.data;
        }

        static SinglyLinkedListNode RemoveDuplicateFromSortedList(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode top = head;

            while (top != null)
            {
                while (top.data == top.next.data || top.next != null)
                {
                    top.next = top.next.next;
                }

                top = top.next;
            }

            return head;
        }

        static SinglyLinkedListNode MergeSortedLists(SinglyLinkedListNode list1, SinglyLinkedListNode list2)
        {
            SinglyLinkedListNode node, head;

            if (list1.data < list2.data)
            {
                node = list1;
                list1 = list1.next;
            }
            else
            {
                node = list2;
                list2 = list2.next;
            }

            head = node;

            while (list1 != null || list2 != null)
            {
                if (list1.data < list2.data)
                {
                    node.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    node.next = list2;
                    list2 = list2.next;
                }
                node = node.next;

            }

            if (list1 != null)
                node.next = list1;
            else
                node.next = list2;

            return head;
        }

        static bool ContainsCycle(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode fast = head.next, slow = head;

            while (true)
            {
                if (fast == slow)
                {
                    return true;
                }

                if (fast == null || fast.next == null)
                {
                    break;
                }

                fast = fast.next.next;
                slow = slow.next;

            }

            return false;
        }

    }

    public class SinglyLinkedListNode
    {
        internal SinglyLinkedListNode next;
        internal int data;
    } 

}
