using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureInterviewPrep.DataStructureTypes
{
    public static class StackExamples
    {
        public static bool IsBalancedBracket()
        {
            string exp = "[()]{}{[()()]()}";

            //initialize new char stack for storing expression
            Stack<char> charStack = new Stack<char>();

            //item item in char array
            foreach (char c in exp)
            {
                //push item to stack if it equal to any of opening bracket type
                if (c == '[' || c == '{' || c == '(')
                {
                    charStack.Push(c);
                }
                else
                {
                    //if item is of any closing bracket, peek and check with top item in stack
                    char peekStack = charStack.Peek();

                    if(peekStack == '{' && c == '}' ||
                        peekStack == '[' && c == ']' ||
                        peekStack == '(' && c == ')')
                    {
                        //if opening and closing bracket matches, then pop
                        charStack.Pop();
                    }
                }
            }

            return charStack.Count == 0;
        }

        public static string ReverseString(string input)
        {
            //create stack to store characters
            Stack<char> charStack = new Stack<char>();

            //push each char of input string onto the stack
            foreach (char c in input)
            {
                charStack.Push(c);
            }

            // Pop characters from the stack and put them back into the input string
            // starting from the 0’th index to reverse the string
            char[] reversedChars = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                reversedChars[i] = charStack.Pop();
            }

            // Convert the character array to a string
            string reversedString = new string(reversedChars);

            return reversedString;
        }

        //method to convert postfix to prefix using stack
        //formula: operator + operand2 + operand1
        //push until operand is hit
        //once operator found, pop 2 operand and perform formula
        public static string ConvertPostfixToPrefix()
        {
            string postfix = "AB+CD-*";// "ABC/-AK/L-*";

            //string stack to store the expresion
            char[] postfixCharArray = postfix.ToCharArray();

            Stack<string> stringStack = new Stack<string>();
            foreach (char c in postfixCharArray)
            {
                //push c until operator is hit
                if(IsOperator(c)) {
                    //if operator is encounter, pop two operand and perform formula
                    string operand1 = stringStack.Pop();
                    string operand2 = stringStack.Pop();
                    string formulatedValue = c + operand2 + operand1;

                    //push value back to stack
                    stringStack.Push(formulatedValue);
                }
                else //if not operator, insert into stack
                {
                    stringStack.Push(c.ToString());
                }                
            }

            string prefix = string.Empty;
            for (int i = 0; i < stringStack.Count; i++)
            {
                prefix += stringStack.Pop();
            }
                
            return prefix;
        }
        private static bool IsOperator(char c)
        {
            string operatorList = "+-/*";
            if (operatorList.Contains(c)) return true;
            return false;
        }

        //method to delete middle element from stack recursively
        public static void DeleteMiddleElement(System.Collections.Stack middleElementStack, int current)
        {
            //base condition: if current position is 1, pop the element
            if(current ==1)
            {
                middleElementStack.Pop();
                return;
            }

            //pop the element
            int temp = (int)middleElementStack.Pop();

            //recursively call DeleteMiddleElement  with current position decremented
            DeleteMiddleElement(middleElementStack, current - 1);

            //push popped element back if its's not the middle one
            middleElementStack.Push(temp);
        }

        // Method to print the stack
        public static void PrintStackElements(System.Collections.Stack stack)
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

    }
}
