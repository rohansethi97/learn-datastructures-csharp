namespace Data_Structures.Stack
{
    class Stack
    {
        public static int Peek(StackNode top)
        {
            return top.data;
        }

        public static int Pop(StackNode top)
        {
            int data = top.data;
            top = top.next;
            return data;
        }

        public static StackNode Push(StackNode top, int data)
        {
            var newNode = CreateStackNode(data);
            newNode.next = top;

            return newNode;
        }

        public static StackNode CreateStackNode(int data)
        {
            return new StackNode { data = data };
        }
    }

    class StackNode
    {
        public StackNode next;
        public int data;
    }


}
