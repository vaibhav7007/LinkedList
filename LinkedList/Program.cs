using System;

namespace DataStructure_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the data structure linked list");
            //UC1 Simple LinkedList
            LinkedList list = new LinkedList();
            //UC2 adding elements to linked list
            list.Insert(70);
            list.Insert(30);
            list.Insert(56);
            list.Display();
        }
    }
}
