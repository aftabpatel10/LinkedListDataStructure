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
                "1 : Adding elements by BuiltIn-LinkedList\n" );
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    //creating (using built in) LinkedList UC1
                    case 1:
                        DefaultLinkedList.AddingElements();             
                        break;
                    
                    default:
                        Console.WriteLine("Invalid option selected .Please try again !");
                        break;
                }
            }
        }
    }
}
