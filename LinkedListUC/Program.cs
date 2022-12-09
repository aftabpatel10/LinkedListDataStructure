using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList UCs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nPlease choose as per the given options -\n" +
                "1 : Adding elements by BuiltIn-LinkedList\n" +
                "2 : Adding elements by using Custom LinkedList\\n\"" +
                "3 : AddFirst in LinkedList \n" +
                "4 : Insertion between elements.\n" +
                "5 : Deleting First Element from the LL.\n" +
                "6 : Deleting Last Element from the LL.\n" +
                "7 : Searching any given Node.\n" +
                "8 : Insert Element after given node.\n" +
                "9: Delete any node from middle of LL.\n");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    //creating (using built in) LinkedList UC1
                    case 1:
                        DefaultLinkedList.AddingElements();             
                        break;
                    //creating CustomLinkedList UC1
                    case 2:
                        CustomLinkedList customLinkedList = new CustomLinkedList();
                        customLinkedList.AddLast(56);                   
                        customLinkedList.AddLast(30);
                        customLinkedList.AddLast(70);
                        customLinkedList.Display();
                        break;
                    case 3:
                        CustomLinkedList customLinkedList2 = new CustomLinkedList();
                        customLinkedList2.Append(56);                   //Append() UC3
                        customLinkedList2.Append(30);
                        customLinkedList2.Append(70);
                        customLinkedList2.Display();
                        break;
                    //InsertBetweenNodes() UC4.
                    case 4: //add nodes 56 and 70 .insert 30 between 56 and 70 . sequence -> 56,30,70 .
                        CustomLinkedList customLinkedList3 = new CustomLinkedList();
                        customLinkedList3.AddFirst(56);
                        customLinkedList3.AddLast(70);
                        customLinkedList3.InsertBetweenNodes(56, 30, 70);   
                        customLinkedList3.Display();
                        break;
                    //Deleting First Node UC5.
                    case 5:
                        CustomLinkedList customLinkedList4 = new CustomLinkedList();
                        customLinkedList4.AddFirst(56);
                        customLinkedList4.AddLast(30);
                        customLinkedList4.AddLast(70);
                        customLinkedList4.Display();
                        customLinkedList4.RemoveFirst();            
                        customLinkedList4.Display();
                        break;
                    //Deleteing Last Node UC6.
                    case 6:
                        CustomLinkedList customLinkedList5 = new CustomLinkedList();
                        customLinkedList5.AddFirst(56);
                        customLinkedList5.AddLast(30);
                        customLinkedList5.AddLast(70);
                        customLinkedList5.Display();
                        customLinkedList5.RemoveLast();             
                        customLinkedList5.Display();
                        break;
                    //Searching any given Node .UC7
                    case 7:
                        CustomLinkedList customLinkedList6 = new CustomLinkedList();
                        customLinkedList6.AddFirst(56);
                        customLinkedList6.AddLast(30);
                        customLinkedList6.AddLast(70);
                        customLinkedList6.SearchNode(30);       
                        break;
                    case 8: //UC8.Insert 40 after 30 .
                        CustomLinkedList customLinkedList7 = new CustomLinkedList();
                        customLinkedList7.AddLast(56);
                        customLinkedList7.AddLast(30);
                        customLinkedList7.AddLast(70);
                        customLinkedList7.Display();
                        customLinkedList7.InsertAfter(30, 40);      
                        customLinkedList7.Display();
                        break;
                    //UC9   delete 40 .
                    case 9:    
                        CustomLinkedList customLinkedList8 = new CustomLinkedList();
                        customLinkedList8.AddFirst(56);
                        customLinkedList8.AddLast(30);
                        customLinkedList8.AddLast(40);
                        customLinkedList8.AddLast(70);
                        customLinkedList8.Display();
                        customLinkedList8.DeleteFromMiddle(40);     
                        customLinkedList8.Display();
                        Console.WriteLine("Linked List Size is : " + customLinkedList8.Size());       
                        break;
                    default:
                        Console.WriteLine("Invalid option selected .Please try again !");
                        break;
                }
            }
        }
    }
}
