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

            char[] postfixCharArray = postfix.ToCharArray();

            //string stack to store the expresion
            Stack<string> stringStack = new Stack<string>();
            foreach (char c in postfixCharArray)
            {
                //push c until operator is hit
                if(IsOperator(c)) {
                    //if operator is encounter, pop two operand and perform formula
                    //formula: operator + operand2 + operand1
                    string operand1 = stringStack.Pop();
                    string operand2 = stringStack.Pop();
                    string calculatedValue = c + operand2 + operand1;

                    //push value back to stack
                    stringStack.Push(calculatedValue);
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

        //convert prefix to postfix 
        //first need to Reverse and solve using formula
        //use formula operand1 + operand2 + operator
        public static string ConvertPrefixToPostfix()
        {
            string input = "*-A/BC-/AKL";

            //convert reversed input to char array
            char[] prefixCharArray = input.ToCharArray();

            //reverse the array
            Array.Reverse(prefixCharArray);

            //store calculated value to string stack
            Stack<string> stringStack = new Stack<string>();

            foreach (char c in prefixCharArray)
            {
                //if operand, push to stack
                if (IsOperator(c))
                {
                    //pop two items and perform formula
                    //formula: operand1 + operand2 + operator
                    string operand1 = stringStack.Pop();
                    string operand2 = stringStack.Pop();
                    string calculatedValue = operand1 + operand2 + c;

                    stringStack.Push(calculatedValue);
                }
                else
                {
                    stringStack.Push(c.ToString());
                }                
            }
            string postfix = string.Empty;
            for (int i = 0; i < stringStack.Count; i++)
            {
                postfix += stringStack.Pop();
            }

            return postfix;
        }

        private static bool IsOperator(char c)
        {
            string operatorList = "+-/*";
            if (operatorList.Contains(c)) return true;
            return false;
        }

        //method to delete middle element from stack recursively
        public static void DeleteMiddleElement(Stack<int> middleElementStack, int current)
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
        public static void PrintStackElements(Stack<int> stack)
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

    }
}
