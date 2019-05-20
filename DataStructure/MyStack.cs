using static System.Console;

namespace DataStructure
{
    public class MyStack
    {
        public int[] Contents { get; set; }
        public int Top { get; set; } = -1;

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

        public void PrintAll()
        {
            if(Top == -1)
            {
                WriteLine("Stack is empty.");
                return;
            }
            int top = Top;
            while(top >= 0)
            {
                WriteLine(Contents[top--]);
            }
        }
    }
}
