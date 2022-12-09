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
                "3 : AddFirst in LinkedList \n");
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
                    default:
                        Console.WriteLine("Invalid option selected .Please try again !");
                        break;
                }
            }
        }
    }
}
