using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsFor214
{

    internal class Program
    {
        public static void printList(Node<int> head)
        {

            Node<int> current = head;
            while (current != null)
            {
                Console.Write($" {current.GetValue()}>>");
                current = current.GetNext();
            }
            Console.WriteLine("null");


        }

        public static int sumList(Node<int> head)
        {
            int sum = 0;
            while (head != null)
            {
                sum = sum + head.GetValue();
                head = head.GetNext();
            }
            return sum;
        }

        public static Node<int> AddToHeadList(Node<int> head, int value)
        {
            // הגדרת חוליה חדשה עם הערך שהתקבל 
            Node<int> temp = new Node<int>(value);
            // שינוי הפנייה בחוליה החדשה מנאל לרשימה שהתקבלה
            temp.SetNext(head);
            return temp;


        }
        public static Node<int> AddToTailList(Node<int> head, int value)
        {
            // הגדרת חוליה חדשה עם הערך שהתקבל 
            Node<int> temp = new Node<int>(value);
            Node<int> current = head;
            while (current.HasNext())
            {
                current = current.GetNext();
            }

            current.SetNext(temp);
            return head;

        }

        public static Node<int> AddNodeToNPlace(Node<int> head, int value, int nLoc)
        {
            Node<int> current = head;
            Node<int> temp = new Node<int>(value);

            for (int i = 1; i < nLoc; i++)
            {
                current = current.GetNext();
            }
            temp.SetNext(current.GetNext());
            current.SetNext(temp);
            return head;
        }
        static Node<T> CreateLinkedList<T>(params T[] values)
        {
            Node<T> head = null;
            Node<T> current = null;

            for (int i = 0; i < values.Length; i++)
            {
                T value = values[i];

                if (head == null)
                {
                    head = new Node<T>(value);
                    current = head;
                }
                else
                {
                    Node<T> newNode = new Node<T>(value);
                    current.SetNext(newNode);
                    current = newNode;
                }
            }

            return head;
        }

        public static bool isPrefix(Node<int> lst1, Node<int> lst2)
        {
            Node<int> head1 = lst1;
            Node<int> head2 = lst2;

            if (head1 == null)
            {
                return false;
            }

            while (head1 != null)
            {

                if (head2 == null)
                {
                    return false;
                }
                if (head1.GetValue() != head2.GetValue())
                {
                    return false;
                }
                head1 = head1.GetNext();
                head2 = head2.GetNext();
            }
            return true;


        }

        public static bool IsSubChain(Node<int> lst1, Node<int> lst2)
        {
            Node<int> head1 = lst1;
            Node<int> head2 = lst2;

            while (head2 != null)
            {
                if (isPrefix(head1, head2))
                {
                    return true;
                }
                head2 = head2.GetNext();
            }
            return false;
        }

        public static Node<int> CopyList(Node<int> original)
        {
            // if the list is not empty
            if (original == null)
            {
                return null;
            }
            //                                the number here doesn't matter
            Node<int> ListToReturn = new Node<int>(-111);

            Node<int> curr = ListToReturn;
            while (original != null)
            {
                Node<int> NodeToAdd = new Node<int>(original.GetValue());
                curr.SetNext(NodeToAdd);
                curr = curr.GetNext();
                original = original.GetNext();
            }
            return ListToReturn.GetNext();

        }

        public static Node<int> CopyEven(Node<int> original)
        {
            // if the list is not empty
            if (original == null)
            {
                return null;
            }
            //                             the number here doesn't matter
            Node<int> ListToReturn = new Node<int>(-9);
            
            Node<int> curr = ListToReturn;
            while (original != null)
            {
                if (original.GetValue() % 2 == 0)
                {
                    Node<int> NodeToAdd = new Node<int>(original.GetValue());
                    curr.SetNext(NodeToAdd);
                    curr = curr.GetNext();
                }        
                original = original.GetNext();
            }
            return ListToReturn.GetNext();
        }
        public static Node<int> CopyEvenOdd(Node<int> original)
        {
            // if the list is not empty
            if (original == null)
            {
                return null;
            }
            //                             the number here doesn't matter
            Node<int> ListToReturn = new Node<int>(-9);
            Node<int> original2 = original;
            Node<int> curr = ListToReturn;
            while (original != null)
            {
                if (original.GetValue() % 2 == 0)
                {
                    Node<int> NodeToAdd = new Node<int>(original.GetValue());
                    curr.SetNext(NodeToAdd);
                    curr = curr.GetNext();
                }
                original = original.GetNext();
            }
            while (original2 !=  null)
            {
                if (original2.GetValue() % 2 == 1)
                {
                    Node<int> NodeToAdd = new Node<int>(original2.GetValue());
                    curr.SetNext(NodeToAdd);
                    curr = curr.GetNext();
                }
                original2 = original2.GetNext();
            }
            return ListToReturn.GetNext();

        }
        public static bool IsExist(Node<int> head, int num) 
        { 
            while(head != null)
            {
                if(head.GetValue() == num)
                {
                    return true;
                }
                head = head.GetNext();
            }
            return false;
        }
        public static Node<int> NoDup(Node<int> original)
        {
            if (original == null) 
            { 
                return null; 
            }
            Node<int> listToReturn = new Node<int>(original.GetValue());
            Node<int> curr = listToReturn;
            while(original != null)
            {
                if(IsExist(listToReturn, original.GetValue()))
                {
                    Node<int> nodeToAdd = new Node<int>(original.GetValue());
                    curr.SetNext(nodeToAdd);
                    curr = curr.GetNext();
                }
                original = original.GetNext();
            }
            return listToReturn;
        }

        static void Main(string[] args)
        {
            Node<int> lst1OnMain = CreateLinkedList(1, 3, 3);

            // Create the second linked list (lst2OnMain)
            Node<int> lst2OnMain = CreateLinkedList(9, 12, 1, 2, 3, 7);
            printList(lst1OnMain);
            printList(lst2OnMain);

            Node<int> copyOnMain = CopyEvenOdd(lst2OnMain);
            printList(copyOnMain);
            
        }
    }
}
