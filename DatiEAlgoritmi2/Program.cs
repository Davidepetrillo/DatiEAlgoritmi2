using System.Diagnostics;
using System;

namespace DatiEAlgoritmi2
{
    class TestSingleLinkList
    {
        private static Node head;
        private static Node tail;

        public static Node Init()
        {
            // primo nodo chiamato testa nodo
            head = new Node("A", null);

            Node nodeB = new Node("B", null);
            head.next = nodeB;

            Node nodeC = new Node("C", null);
            nodeB.next = nodeC;

            //ultimo nodo chiamato coda nodo
            tail = new Node("D", null);
            nodeC.next = tail;

            return head;
        }

        public static void Print(Node node)
        {
            Node p = node;

            while(p!= null)
            {
                Console.Write(p.data + " -> ");
                
                p = p.next;
            }
            Console.Write(" End\n\n");
        }

        public static void Main(string[] args)
        {
            Init();
            Insert(2,new Node("E", null));
            Add(new Node("E", null));
             Remove(2);
            Print(head);
        }

        public static void Add(Node newNode)
        {
            tail.next = newNode;
            tail = newNode;
        }

        public static void Insert(int insertPosition, Node newNode)
        {
            Node p = head;
            int i = 0;

            while(p.next!= null && i < insertPosition - 1)
            {
                p = p.next;
                i++;
            }

            newNode.next = p.next;
            p.next = newNode;
        }

        public static void Remove(int removePosition)
        {
            Node p = head;
            int i = 0;

            while (p.next != null && i < removePosition - 1)
            {
                p = p.next;
                i++;
            }
            Node temp = p.next;
            p.next = p.next.next;
            temp.next = null;
        }
    }
}
