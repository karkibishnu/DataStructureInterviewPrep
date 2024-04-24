using System;

namespace DataStructureInterviewPrep.DataStructureTypes.Stack
{
    public static class StackOperation
    {
        //method to push elements onto the stack
        public static void PushToStack(System.Collections.Stack stack, int[] elements)
        {
            foreach (var element in elements)
            {
                stack.Push(element);
            }

            Console.WriteLine("Stack elements after push");
            PrintStackElements(stack);
        }

        //method to return size of stack
        public static int SizeOfStack(System.Collections.Stack stack)
        {
            if (stack == null) return 0;
            return stack.Count;
        }

        //method to peek the top element of stack without removing it
        public static int PeekStack(System.Collections.Stack stack)
        {
            Console.WriteLine("Peek stack element");
            return (int)stack.Peek();
        }

        //method to pop elements from stack and print them
        public static void PopAndPrintStack(System.Collections.Stack stack)
        {
            Console.WriteLine("Popping elements from stack");
            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }

        //method to check if stack is empty
        public static bool IsStackEmpty(System.Collections.Stack stack)
        {
            return stack.Count == 0;
        }

        //method to print elements of the stack
        public static void PrintStackElements(System.Collections.Stack stack)
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
