﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUC
{
    public class CustomLinkedList
    {
        public Node head;
        public Node sorted;
        public void AddLast(int data)       //creating LinkedList UC1
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine($"{newNode.data} is added in list ");
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.WriteLine($"{newNode.data} is added.");
            }
        }
        public void Display()           //Display()
        {
            Console.Write("Displaying Nodes ");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
            Console.WriteLine();
        }
        //AddFirst UC2
        public void AddFirst(int data)      
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine($"{newNode.data} is added into the list.");
        }
        public void Append(int data)
        {
            AddLast(data);
        }
        //InsertBetweenNodes() UC4.
        public void InsertBetweenNodes(int insertAfter, int data, int insertBefore)       
        {
            Node newNode = new Node(data);
            bool isFound = false;
            Node temp = head;
            if (temp == null)
                Console.WriteLine("Linked List is empty");
            else
            {
                while (temp != null)
                {
                    if (temp.data == insertAfter && temp.next.data == insertBefore)
                    {
                        //Console.WriteLine($"{temp.data} node is present");
                        newNode.next = temp.next;
                        temp.next = newNode;
                        Console.WriteLine($"{newNode.data} insertion done between {temp.data} and {newNode.next.data}.");
                        isFound = true;
                        break;
                    }
                    temp = temp.next;
                }
            }
            if (!isFound)
                Console.WriteLine($"{data} node is not present.");
        }
        //RemoveFirst UC5 
        public void RemoveFirst()      
        {
            if (head == null)
                Console.WriteLine("LinkedList is emty");
            else
            {
                int deletedNode = head.data;
                head = head.next;
                Console.WriteLine($"{deletedNode} is removed from Linkedlist");
            }
        }
        //RemoveLast UC6
        public void RemoveLast()        
        {
            Node temp = head;
            if (head == null)
                Console.WriteLine("LinkedList is emty");
            else if (temp.next == null)
            {
                int data = temp.data;
                head = null;
                Console.WriteLine($"{data} is deleted");
            }
            else
            {
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                int lastDeletedNode = temp.next.data;
                temp.next = null;
                Console.WriteLine($"{lastDeletedNode} node is deleted");
            }
        }
    }
}
