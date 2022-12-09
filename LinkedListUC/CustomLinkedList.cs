using System;
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
    }
}
