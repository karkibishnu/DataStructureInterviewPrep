using DataStructureInterviewPrep.DataStructureTypes;
using DataStructureInterviewPrep.DataStructureTypes.Arrays;
using DataStructureInterviewPrep.DataStructureTypes.Dictionary;
using DataStructureInterviewPrep.DataStructureTypes.LinkedList.SinglyLinkedList;
using DataStructureInterviewPrep.DataStructureTypes.Stack;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructureInterviewPrep
{
    public static class Program
    {      
        static void Main(string[] args)
        {
            //data initialization for checking if lists are Identical or not
            LinkedList list = new LinkedList();  // Create a new linked list
            LinkedListQuestions list1 = new LinkedListQuestions();
            LinkedListQuestions list2 = new LinkedListQuestions();

            //adding nodes to linked list
            for (int i = 1; i <= 5; i++) { list.AddEnd(i); }

            //adding new node to the beginning of existing nodes
            list.AddBeginning(6);
            list.AddBeginning(7);

            //adding a node in the middle of the list
            list.AddMiddle(9, 3);

            list1.AddEnd(1);
            list1.AddEnd(2);
            list1.AddEnd(2);
            list1.AddEnd(3);
            list1.AddEnd(3);
            list1.AddEnd(3);
            
            list2.AddEnd(1);
            list2.AddEnd(2);
            list2.AddEnd(2);
            list2.AddEnd(3);
            list2.AddEnd(3);
            list2.AddEnd(3);

            int key1 = 7;  // Key to search in the list
            int key2 = 11;  // Key not present in the list

            //initialized for later using to remove duplicates from sorted linked list
            LinkedListQuestions linkedListDups = new LinkedListQuestions();
            linkedListDups.AddEnd(11);
            linkedListDups.AddEnd(22);
            linkedListDups.AddEnd(22);
            linkedListDups.AddEnd(33);
            linkedListDups.AddEnd(33);
            linkedListDups.AddEnd(44);

            LinkedListQuestions midLinkedList = new LinkedListQuestions();
            midLinkedList.AddEnd(100);
            midLinkedList.AddEnd(200);
            midLinkedList.AddEnd(300);
            midLinkedList.AddEnd(400);
            midLinkedList.AddEnd(500);
            midLinkedList.AddEnd(600);

            //create stack and push some elements for removing middle item
            Stack<int> middleItemStack = new Stack<int>();
            middleItemStack.Push(1);
            middleItemStack.Push(2);
            middleItemStack.Push(3);
            middleItemStack.Push(4);
            middleItemStack.Push(5);

            while (true)
            {                
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Count words in string using dictionary");
                Console.WriteLine("2. Perform 2D array operation");
                Console.WriteLine("3. Print Pairs using two pointers");
                Console.WriteLine("4. Check if lists are identical");
                Console.WriteLine("5. Print List");
                Console.WriteLine("6. Search using iterative approach");
                Console.WriteLine("7. Search using recursive approach");
                Console.WriteLine("8. Count list nodes");
                Console.WriteLine("9. Count list nodes using recursive");
                Console.WriteLine("10. Reverse list and print before & after");
                Console.WriteLine("11. Reverse list and print before & after recursively");
                Console.WriteLine("12. Reverse list using stack");
                Console.WriteLine("13. Delete an item from the beginning of the list");
                Console.WriteLine("14. Delete an item from the middle of the list");
                Console.WriteLine("15. Delete an item from end of the list");
                Console.WriteLine("16. Delete an item from the list using recursive");
                Console.WriteLine("17. Remove Duplicates");
                Console.WriteLine("18. Find middle node using arraylist");
                Console.WriteLine("19. Stack operations");
                Console.WriteLine("20. Check Balanced Stack");
                Console.WriteLine("21. Reverse String using Stack");                
                Console.WriteLine("22. Delete middle of Stack recursively");
                Console.WriteLine("23. Postfix to prefix");
                Console.WriteLine("24. Prefix to postfix");
                Console.WriteLine("25. Queue operations");
                Console.WriteLine("99. Exit");
                Console.Write("Enter your choice (1 through 98, 99 to Exit)");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        WordCounter.CountWords();
                        break;
                    case "2":
                        ArraysOperation.Array2DExample();
                        break;
                    case "3":
                        TwoPointer.PrintPairsWithPositiveAndNegative();
                        break;
                    case "4":
                        Console.WriteLine($"Are the lists identical? {list1.AreIdentical(list1, list2)}");
                        break;
                    case "5":
                        list.PrintList();
                        break;
                    case "6":
                        list.SearchUsingIterativeApproach(key1);
                        list.SearchUsingIterativeApproach(key2);
                        break;
                    case "7":
                        Console.WriteLine($"Recursive Search for {key1}: {(list.SearchRecursive(key1) ? "Yes" : "No")}");
                        Console.WriteLine($"Recursive Search for {key2}: {(list.SearchRecursive(key2) ? "Yes" : "No")}");
                        break;
                    case "8":
                        Console.WriteLine($"Number of nodes in the list using iterative: {list.CountAvailableNodesIterative()}");
                        break;
                    case "9":
                        int nodeCount = list.CountNodesRecursive();
                        Console.WriteLine($"Number of nodes in the list using recursive: {nodeCount}");
                        break;
                    case "10":
                        list.PrintList();
                        list.ReverseList();
                        list.PrintList();
                        break;
                    case "11":
                        list.PrintList();
                        list.ReverseRecursive();
                        list.PrintList();
                        break;
                    case "12":
                        list.PrintList();
                        list.ReverseWithStack();
                        list.PrintList();
                        break;
                    case "13":
                        list.PrintList();
                        list.DeleteBeginning();
                        list.PrintList();
                        break;
                    case "14":
                        list.PrintList();
                        list.DeleteMiddle(2);
                        list.PrintList();
                        break;
                    case "15":
                        list.PrintList();
                        list.DeleteEnd();
                        list.PrintList();
                        break;
                    case "16":
                        list.PrintList();
                        list.DeleteNodeByKeyRecursive(2);
                        list.PrintList();
                        break;
                    case "17":
                        list.PrintList();
                        linkedListDups.RemoveDuplicates();
                        list.PrintList();
                        break;
                    case "18":
                        Node middleNode = midLinkedList.FindMiddleUsingArrayList();
                        midLinkedList.PrintList();
                        Console.WriteLine($"Middle node: {middleNode.Data}");
                        break;
                    case "19":
                        Stack myStack = new Stack();
                        StackOperation.PushToStack(myStack, new[] { 11, 22, 33, 44, 55, 66 });
                        Console.WriteLine($"Size of stack: {StackOperation.SizeOfStack(myStack)}");
                        Console.WriteLine($"Top element of the stack: {StackOperation.PeekStack(myStack)}");
                        StackOperation.PopAndPrintStack(myStack);
                        bool isEmpty = StackOperation.IsStackEmpty(myStack);
                        Console.WriteLine($"Is the stack empty? {isEmpty}");
                        break;
                    case "20":
                        bool isBalanced = StackExamples.IsBalancedBracket();
                        Console.WriteLine($"Is stack balanced: {isBalanced}");
                        Console.WriteLine();
                        break;
                    case "21":
                        string input = "Hello World";
                        string reversedString = StackExamples.ReverseString(input);
                        Console.WriteLine($"Original string: {input}");
                        Console.WriteLine($"Reversed string: {reversedString}");
                        Console.WriteLine();
                        break;
                    case "22":
                        Console.WriteLine($"Original Stack: {middleItemStack}");
                        StackExamples.PrintStackElements(middleItemStack);
                        StackExamples.DeleteMiddleElement(middleItemStack, (middleItemStack.Count / 2) + 1);
                        Console.WriteLine($"Stack after deleting middle element:");
                        StackExamples.PrintStackElements(middleItemStack);
                        break;
                    case "23":
                        string prefix = StackExamples.ConvertPostfixToPrefix();
                        Console.WriteLine($"Postfix to prefix: {prefix}");
                        break;
                    case "24":
                        string postfix = StackExamples.ConvertPrefixToPostfix();
                        Console.WriteLine($"Prefix to postfix: {postfix}");
                        break;
                    case "25":
                        Queue<int> insertedQueue = QueueOperation.InsertInQueue();
                        Console.WriteLine($"Queue count: {insertedQueue.Count}");
                        Console.WriteLine($"Peek value: {QueueOperation.PeekQueue(insertedQueue)}");
                        QueueOperation.DeleteInQueue(insertedQueue);
                        Console.WriteLine($"Queue count: {insertedQueue.Count}");
                        Console.WriteLine($"Is Queue Empty: {QueueOperation.IsQueueEmpty(insertedQueue)}");
                        break;
                    case "99":
                        Console.WriteLine("Exiting program");
                        return;
                    default:
                        Console.WriteLine("Invalid option, please choose again");
                        break;
                }
            }
        }
    }
}
