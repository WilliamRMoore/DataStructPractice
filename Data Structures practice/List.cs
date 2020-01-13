using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_practice
{
    class List
    {
        Node First;
        Node Current;
  

        public void PrintList()
        {
            Console.WriteLine("\n Now prining the List \n");
            Current = First;
            while(Current != null)
            {
                
                Console.WriteLine($"{Current._value} \n");
                Current = Current.next;
            }
            Console.WriteLine("\nNow the list is being printed recursivly");
            PrintListRecursive(First);
        }

        public void PrintListRecursive(Node current)
        {
            if(current == null)
            {
                return;
            }
            Console.WriteLine($"{current._value} \n");

            current = current.next;
            PrintListRecursive(current);
        }

        public void DeleteNode(Node node)
        {
            var DelNode = Search(node);

            if(DelNode.Previous == null)
            {
                First = DelNode.next;
                DelNode.next.Previous = null;
                DelNode.next = null;
                return;
            }
            if(DelNode.next != null)
            {
                DelNode.next.Previous = DelNode.Previous;
            }
           
            DelNode.Previous.next = DelNode.next;
            DelNode.next = null;
            DelNode.Previous = null;
        }

        public Node Search (Node node)
        {
            Current = First;
            while(Current != null)
            {
                if(Current._value == node._value)
                {
                    return Current;
                }
                Current = Current.next;
            }
            return Current;
        }

        public void Insert (Node node)
        {
            if(First == null)
            {
                First = node;
            }
            else
            {

                Current = First;
                while (Current != null)
                {
                    if (Current._value > node._value)
                    {
                        node.Previous = Current.Previous;
                        Current.Previous = node;

                        if (node.Previous != null)
                        {
                            node.Previous.next = node;
                        }
                        else
                        {
                            First = node;
                        }
                        node.next = Current;
                        break;
                    }
                    if (Current.next == null)
                    {
                        node.Previous = Current;
                        Current.next = node;
                        break;
                    }
                    Current = Current.next;
                }
            }

            return;
        }
    }
}
