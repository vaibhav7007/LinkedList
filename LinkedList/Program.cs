using System;

namespace DataStructure_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the data structure linked list");
            LinkedList list = new LinkedList();
            //UC3 Appending elements
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Display();
        }
    }
}