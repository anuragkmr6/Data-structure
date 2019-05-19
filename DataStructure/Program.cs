using System;
using static System.Console;

namespace DataStructure
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SinglyLinkedList list = new SinglyLinkedList();
            for (int i = 1; i <= 5; i++)
            {
                list.Add(i);
            }
            //list.Add(1);
            //list.Add(2);
            //list.Add(1);
            WriteLine("Original Linked list:");
            list.Print();
            /*
            list.AddAtStart(6);
            WriteLine("\nAfter adding node at first");
            list.Print();

            list.Add(11);
            WriteLine("\nAfter adding node at last");
            list.Print();

            list.AddAfter(4, 99);
            WriteLine("\nAdding node after");
            list.Print();
            
            list.AddBefore(5, 77);
            WriteLine("\nAdding node before");
            list.Print();
            
            list.Reverse();
            WriteLine("After reverse");
            list.Print();
            
            list.DeleteFirst();
            WriteLine("After deleting first node:");
            list.Print();
            
            list.DeleteLast();
            WriteLine("After deleting last node:");
            list.Print();
            
            list.Delete(3);
            WriteLine("After delete:");
            list.Print();

            WriteLine($"Linked list count: {list.Count()}");

            WriteLine($"Linked list is palindrome: {list.IsPalindrome()}");
            */
            list.PrintFromLast(5);
            ReadLine();

        }
    }
}