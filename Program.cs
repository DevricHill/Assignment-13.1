namespace Assignment_13._1
{
    internal class Program
    {
        public class Node
        {
            public int Data;
            public Node Next;

            public Node(int data) 
            { 
                Data = data;
                Next = null;
            }
        }

        public class LinkedList
        {
            Node Head;
            Node Tail;
            int size;

            public LinkedList()
            {
                Head = Tail = null;
                size = 0;
            }

            public Node GetHead { get { return Head; } }
            bool IsEmpty { get { return size == 0; } }

            public void Add(int data)
            {
                Node newNode = new Node(data);

                if (IsEmpty)
                {
                    Head = newNode;
                    Tail = newNode;
                }
                else
                {
                    Tail.Next = newNode;
                    Tail = newNode;
                }

                size++;
            }
        } 

        static LinkedList AddLinkedList(LinkedList LL1, LinkedList LL2)
        {
            Node temp1 = LL1.GetHead;
            Node temp2 = LL2.GetHead;
            LinkedList result = new LinkedList();
            int carry = 0;

            while(temp1 != null || temp2 != null)
            {
                int total = 0;

                if(temp1!= null)
                {
                    total += temp1.Data;
                }

                if (temp2 != null)
                {
                    total += temp2.Data;
                }

                total += carry;

                if (total >= 10)
                {
                    carry = total / 10;
                }
                else
                {
                    carry = 0;
                }

                result.Add(total % 10);

                if (temp1 != null)
                {
                    temp1 = temp1.Next;
                }

                if(temp2 != null)
                {
                    temp2 = temp2.Next;
                }
                
            }

            if (carry != 0)
            {
                result.Add(carry % 10);

                if(carry >= 10)
                {
                    result.Add(carry / 10);
                }
            }

            return result;
        }

        static void PrintList(LinkedList LL)
        {
            Node temp = LL.GetHead;

            while (temp != null)
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.Next;
            }
            Console.WriteLine('\n');
        }

        static void LinkedListReverseAdd()
        {
            Console.WriteLine("This Program show the sum of two LinkedList that is stored in reverse order. ");

            LinkedList LL = new LinkedList();
            LinkedList LL2 = new LinkedList();

            LL.Add(2);
            LL.Add(4);
            LL.Add(3);

            LL2.Add(5);
            LL2.Add(6);
            LL2.Add(4);

            LinkedList result = AddLinkedList(LL, LL2);

            Console.WriteLine("List 1: ");
            PrintList(LL);
            Console.WriteLine("List 2: ");
            PrintList(LL2);
            Console.WriteLine("Result: ");
            PrintList(result);
            

            LinkedList LL3 = new LinkedList();
            LinkedList LL4 = new LinkedList();

            LL3.Add(0);
            LL4.Add(0);
            result = AddLinkedList(LL3, LL4);

            Console.WriteLine("List 1: ");
            PrintList(LL3);
            Console.WriteLine("List 2: ");
            PrintList(LL4);
            Console.WriteLine("Result: ");
            PrintList(result);


            LinkedList LL5 = new LinkedList();
            LinkedList LL6 = new LinkedList();

            LL5.Add(9);
            LL5.Add(9);
            LL5.Add(9);
            LL5.Add(9);
            LL5.Add(9);
            LL5.Add(9);
            LL5.Add(9);

            LL6.Add(9);
            LL6.Add(9);
            LL6.Add(9);
            LL6.Add(9);
            result = AddLinkedList(LL5, LL6);

            Console.WriteLine("List 1: ");
            PrintList(LL5);
            Console.WriteLine("List 2: ");
            PrintList(LL6);
            Console.WriteLine("Result: ");
            PrintList(result);

            
        }

        static void Main(string[] args)
        {
            LinkedListReverseAdd();
        }
    }
}
