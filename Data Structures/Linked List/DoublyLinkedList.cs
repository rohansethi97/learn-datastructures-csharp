namespace Data_Structures.Linked_List
{
    class DoublyLinkedList
    {
        public static DoublyLinkedListNode CreateNode(int data)
        {
            return new DoublyLinkedListNode { data = data };
        }

        public static DoublyLinkedListNode AddNodeToEnd(DoublyLinkedListNode head, int data)
        {
            DoublyLinkedListNode top = head;

            while (top.next != null)
            {
                top = top.next;
            }

            top.next = CreateNode(data);
            top.next.previous = top;

            return head;
        }

        public static DoublyLinkedListNode AddNodeToFront(DoublyLinkedListNode head, int data)
        {
            var node = CreateNode(data);
            node.next = head;
            return node;
        }


        public static DoublyLinkedListNode AddNodeInSortedOrder(DoublyLinkedListNode head, int data, bool isAsc = true)
        {
            var top = head;
            var newNode = CreateNode(data);

            if (top.data < data)
            {
                newNode.next = top;
                top.previous = newNode;

                return newNode;
            }

            while (top.next != null)
            {
                if (top.data <= data && (top.next == null || top.next.data > data))
                {
                    var nextNode = top.next;

                    top.next = newNode;
                    newNode.previous = top;

                    newNode.next = nextNode;

                    if (nextNode != null) nextNode.previous = newNode;

                    break;
                }
                top = top.next;
            }

            return head;
        }

        public static DoublyLinkedListNode ReverseDoublyLinkedList(DoublyLinkedListNode head)
        {
            if (head == null || head.next == null) return head;

            while (head != null)
            {
                var temp = head.next;

                head.next = head.previous;
                head.previous = head.next;

                head = temp;
            }

            return head;

        }
    }

    class DoublyLinkedListNode
    {
        public DoublyLinkedListNode next;
        public DoublyLinkedListNode previous;
        public int data;
    }

}
