using System;
using System.Collections;
using static System.Console;

namespace DataStructure
{
    public class SinglyLinkedList
    {
        public Node First { get; set; }
        public Node Last { get; set; }

        /// <summary>
        /// Adds node at last
        /// </summary>
        /// <param name="data"></param>
        public void Add(int data)
        {
            var node = new Node(data);
            if (First == null)
            {
                First = node;
                Last = node;
                return;
            }

            Last.Next = node;
            Last = node;
        }
        public void AddAtStart(int data)
        {
            var node = new Node(data);
            if (First == null)
            {
                Add(data);
                return;
            }

            node.Next = First;
            First = node;
        }
        /// <summary>
        /// Adds node after an existing node in the list
        /// </summary>
        /// <param name="existingValue"></param>
        /// <param name="newValue"></param>
        public void AddAfter(int existingValue, int newValue)
        {
            if (First == null)
            {
                WriteLine("Linked list is empty.");
                return;
            }
            var temp = First;
            var newNode = new Node(newValue);
            while (temp.Next != null)
            {
                if (temp.Data == existingValue)
                {
                    newNode.Next = temp.Next;
                    temp.Next = newNode;
                    return;
                }
                temp = temp.Next;
            }

            WriteLine($"{existingValue} doesn't exist in the linked list.");
        }
        /// <summary>
        /// Adds node before an existing node in the list
        /// </summary>
        /// <param name="existingValue"></param>
        /// <param name="newValue"></param>
        public void AddBefore(int existingValue, int newValue)
        {
            if (First == null)
            {
                WriteLine("Linked list is empty");
                return;
            }

            var node = new Node(newValue);

            if (First.Data == existingValue)
            {
                node.Next = First;
                First = node;
                return;
            }
            
            var temp = First;
            while(temp.Next != null && temp.Next.Data != existingValue)
            {
                temp = temp.Next;
            }
            if(temp.Next != null)
            {
                node.Next = temp.Next;
                temp.Next = node;
                return;
            }
            WriteLine($"AddBefore()->{existingValue} doesn't exist in linked list");
        }
        public void Reverse()
        {
            var stack = new Stack();
            if (First == null)
            {
                WriteLine("Linked list is empty.");
                return;
            }

            var temp = First;
            while (temp != null)
            {
                stack.Push(temp);
                temp = temp.Next;
            }
            First = null;
            Last = null;
            while (stack.Count > 0)
            {
                var node = (Node)stack.Pop();
                node.Next = null;
                if (First == null && Last == null)
                {
                    First = node;
                    Last = node;
                }
                Last.Next = node;
                Last = node;
            }
        }
        /// <summary>
        /// Delete first element from linked list
        /// </summary>
        public void DeleteFirst()
        {
            if(First == null)
            {
                WriteLine("DeleteFirst()->Linked list is empty.");
                return;
            }
            if(First == Last)
            {
                First = Last = null;
                return;
            }
            var temp = First;
            First = First.Next;
            temp.Next = null;
        }
        /// <summary>
        /// Delete last element from linked list
        /// </summary>
        public void DeleteLast()
        {
            if(First == null)
            {
                WriteLine("DeleteLast()-> Linked list is empty.");
                return;
            }
            if(First == Last)//i.e only one node exists in linked list
            {
                First = Last = null;
                return;
            }
            var secondLastNode = First;
            while(secondLastNode.Next.Next != null)
            {
                secondLastNode = secondLastNode.Next;
            }
            secondLastNode.Next = null;
            Last = secondLastNode;
        }
        public void Delete(int data)
        {
            if(First.Data == data)
            {
                First = First.Next;
                return;
            }

            var temp = First;
            while(temp != null && temp.Next?.Data != data)
            {
                temp = temp.Next;
            }

            if(temp!=null)
            {
                temp.Next = temp.Next.Next;
                return;
            }
            WriteLine($"Delete()-> {data} doesn't exists in the list");
        }
        public int Count()
        {
            return GetCountRecursive(First);
        }
        private int GetCountRecursive(Node first)
        {
            if (first == null)
                return 0;
            return 1 + GetCountRecursive(first.Next);
        }
        public bool IsPalindrome()
        {
            if(First == null)
            {
                WriteLine("IsPalindrome() -> Linked list is empty");
                return false;
            }
            bool palindrome = true;
            var stack = new Stack(Count());
            var temp = First;
            while (temp != null)
            {
                stack.Push(temp.Data);
                temp = temp.Next;
            }
            temp = First;
            while(temp != null)
            {
                int x = (int)stack.Pop();
                if(x != temp.Data)
                {
                    palindrome = false;
                    return palindrome;
                }
                temp = temp.Next;
            }
            return palindrome;
        }

        /// <summary>
        /// Print N-th node from last
        /// </summary>
        /// <param name="positionFromLast">N-th node from last</param>
        public void PrintFromLast(int positionFromLast)
        {
            int count = Count();
            if(positionFromLast > count)
            {
                WriteLine("Invalid postion");
                return;
            }
            int positionFromFirst = count - positionFromLast + 1;
            var temp = First;
            int counter = 0;
            while(temp != null)
            {
                counter++;
                if(counter == positionFromFirst)
                {
                    WriteLine($"{positionFromLast}-th element from last is : {temp.Data}");
                    return;
                }
                temp = temp.Next;
            }
        }
        public void Print()
        {
            if(First ==null)
            {
                WriteLine("Print()->Linked list is empty.");
                return;
            }
            var temp = First;
            while (temp != null)
            {
                Write(temp.Data + " ");
                temp = temp.Next;
            }
            WriteLine();
        }
    }
}