using static System.Console;

namespace DataStructure
{
    public class Sorting
    {
        public void BubbleSort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - i - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        var temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
            }

            WriteLine("Array elements after bubble sort:");
            foreach (var item in input)
            {
                Write(item + " ");
            }
        }

        public void SelectionSort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                int smallestNumberIndex = IndexOfSmallestNumber(input, i);

                Swap(input, i, smallestNumberIndex);
            }

            WriteLine("Array elements after Selection sort:");
            foreach (var item in input)
            {
                Write(item + " ");
            }
        }

        public void InsertionSort(int[] input)
        {
            for(int i= 1; i< input.Length; i++)
            {
                int j = i;

                while(j > 0 && input[j] < input[j-1])
                {
                    Swap(input, j, j - 1);
                    j--;
                }
            }
            WriteLine("Array after sorting:");
            foreach (var item in input)
            {
                Write(item + " ");
            }
            
        }
        private int IndexOfSmallestNumber(int[] input, int i)
        {
            int smallestNumber = input[i];
            int smallestNumberIndex = i;

            for (int j = i; j < input.Length; j++)
            {
                if (smallestNumber > input[j])
                {
                    smallestNumber = input[j];
                    smallestNumberIndex = j;
                }
            }

            return smallestNumberIndex;
        }

        private void Swap(int[] input, int i, int smallestNumberIndex)
        {
            int temp = input[i];
            input[i] = input[smallestNumberIndex];
            input[smallestNumberIndex] = temp;
        }
    }
}