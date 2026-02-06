using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Review.Linkedlist
{
    
        class Node
        {
            public int Data;
            public Node Next;

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }
        class LinkedList
        {
            private Node head;
            public void Add(int data)
            {
                Node newNode = new Node(data);
                if (head == null)
                {
                    head = newNode;
                    return;
                }
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                   
                }
                temp.Next = newNode;

            }
            public void Display()
            {
                if (head == null)
                {
                    Console.WriteLine("List is empty");
                    return;
                }
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.Data + "->");
                    temp = temp.Next;
                }
                Console.WriteLine("Null");

            }
            public void RotateByK(int k)
            {
                if (head == null || k == 0)
                {
                    return;
                }
                int length = GetLength();
            if (k > length)
            {
                Console.WriteLine("Enter valid k");
                return;
            }
                if (k == 0) return;

                Node temp = head;
                for(int i = 1; i < length - k; i++)
                {
                    temp = temp.Next;
                }
                Node newHead = temp.Next;
                temp.Next = null;

                Node tail = newHead;
                while (tail.Next != null)
                {
                    tail = tail.Next;
                }
                
                tail.Next = head;
                head = newHead;
                
            }
            private int GetLength()
            {
                int count = 0;
                Node temp = head;
                while (temp != null)
                {
                    count++;
                    temp = temp.Next;
                }
                return count;
            }

        }
        class RotateLinkedListByKNodes
        {
            static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("Enter number of nodes ");
            int numberOfNodes = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter values of nodes");
            for(int i = 0; i < numberOfNodes; i++)
            {
                int value = int.Parse(Console.ReadLine());
                list.Add(value);
            }
            Console.WriteLine("Enter k for rotation");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Original list: ");
            list.Display();
            list.RotateByK(k);
            Console.WriteLine("List after rotation:");
            list.Display();

        }

        }
    
}
