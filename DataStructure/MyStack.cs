using static System.Console;

namespace DataStructure
{
    public class MyStack
    {
        public int[] Contents { get; set; }
        public int Top { get; set; } = -1;
        public int Count()
        {
            return Top + 1;
        }
        public MyStack(int size)
        {
            if (size > 0)
            {
                Contents = new int[size];
            }
        }
        public void Push(int data)
        {
            Top++;
            Contents[Top] = data;
        }
        public int Pop()
        {
            return Contents[Top--];
        }
        public int Peek()
        {
            return Contents[Top];
        }
        public MyStack Sort()
        {
            var tempStack = new MyStack(Count());
            while (Count() > 0)
            {
                var data = Pop();
                while (tempStack.Count() > 0 && tempStack.Peek() > data)
                {
                    Push(tempStack.Pop());
                }

                tempStack.Push(data);

            }
            return tempStack;
        }
        public void PrintAll()
        {
            if (Top == -1)
            {
                WriteLine("Stack is empty.");
                return;
            }
            int top = Top;
            while (top >= 0)
            {
                Write($"{Contents[top--]} ");
            }
            WriteLine();
        }

        public static void DecimalToBinary(int n)
        {
            WriteLine($"Binary conversion of {n} is:");

            var stack = new MyStack(10);

            while(n>0)
            {
                stack.Push(n % 2);
                n = n / 2;
            }
                        
            stack.PrintAll();
        }

        public void DeleteEvenNumbers()
        {
            var temp = new MyStack(Count());

            while(Top>=0)
            {
                var data = Pop();
                if(data%2==1)
                {
                    temp.Push(data);
                }
            }

            while(temp.Top>=0)
            {
                Push(temp.Pop());
            }

            WriteLine("After deleting all even numbers from stack:");
            PrintAll();
        }
    }
}
