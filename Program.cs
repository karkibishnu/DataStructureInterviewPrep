using DataStructureInterviewPrep.DataStructureTypes.Arrays;
using DataStructureInterviewPrep.DataStructureTypes.Dictionary;
using DataStructureInterviewPrep.DataStructureTypes.LinkedList.SinglyLinkedList;
using DataStructureInterviewPrep.DataStructureTypes.Stack;
using System;
using System.Collections;

namespace DataStructureInterviewPrep
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //counting words in input string using dictionary
            string input = "If you can change your mind, you can change your life";
            WordCounter.CountWords(input);
            Console.WriteLine();

            //array console 
            ArraysOperation.Array2DExample();
            Console.WriteLine();

            //singly linked list adding and traversing
            LinkedList list = new LinkedList();  // Create a new linked list

            //adding nodes to linked list
            list.AddEnd(1);
            list.AddEnd(2);
            list.AddEnd(3);
            list.AddEnd(4);
            list.AddEnd(5);

            //adding new node to the beginning of existing nodes
            list.AddBeginning(6);
            list.AddBeginning(7);

            //adding a node in the middle of the list
            list.AddMiddle(9, 3);

            //printing the linked list
            list.PrintList();
            Console.WriteLine();

            int key1 = 7;  // Key to search in the list
            int key2 = 11;  // Key not present in the list

            // Searching for key1 in the list using iterative approach
            list.SearchUsingIterativeApproach(key1);
            // Searching for key2 in the list using iterative approach
            list.SearchUsingIterativeApproach(key2);

            // Searching for key1 in the list using recursive approach
            Console.WriteLine($"Recursive Search for {key1}: {(list.SearchRecursive(key1) ? "Yes" : "No")}");
            // Searching for key2 in the list using recursive approach
            Console.WriteLine($"Recursive Search for {key2}: {(list.SearchRecursive(key2) ? "Yes" : "No")}");

            // Couting nodes in given linked list
            Console.WriteLine();
            Console.WriteLine($"Number of nodes in the list using iterative: {list.CountAvailableNodesIterative()}");


            // Counting the number of nodes in the list using recursive approach
            Console.WriteLine();
            int nodeCount = list.CountNodesRecursive();
            Console.WriteLine($"Number of nodes in the list using recursive: {nodeCount}");

            //Either do the reverse normally or recursive else it will reverse the reversed linked list
            ////reverse linked list
            //Console.WriteLine();
            //Console.WriteLine("Reversed List normally:");
            //list.ReverseList();
            ////printing the reversed linked list
            //list.PrintList();

            //// Reverse the linked list using recursive approach
            //Console.WriteLine();
            //Console.WriteLine("Reversed List recursively:");
            //list.ReverseRecursive();            
            //list.PrintList();  // Print the reversed list

            //reverse linked list using stack
            Console.WriteLine();
            list.ReverseWithStack();
            Console.WriteLine("Reversed List using stack:");
            list.PrintList();

            //delete an item from the beginning of the list
            Console.WriteLine();
            list.DeleteBeginning();
            Console.WriteLine("List after deleing from beginning");
            list.PrintList();

            //delete an item from the end of the list
            Console.WriteLine();
            list.DeleteEnd();
            Console.WriteLine("List after deleting from end");
            list.PrintList();

            //delete an item from the middle of the list
            Console.WriteLine();
            //list.DeleteMiddle(2);
            //Console.WriteLine($"List after deleting 2 from middle");
            //list.PrintList();

            list.DeleteNodeByKeyRecursive(2); //delete item using recursive
            Console.WriteLine($"List after deleting 2 from middle using recursive");
            list.PrintList();

            //check if lists are identical
            LinkedListQuestions list1 = new LinkedListQuestions();
            list1.AddEnd(1);
            list1.AddEnd(2);
            list1.AddEnd(2);
            list1.AddEnd(3);
            list1.AddEnd(3);
            list1.AddEnd(3);

            LinkedListQuestions list2 = new LinkedListQuestions();
            list2.AddEnd(1);
            list2.AddEnd(2);
            list2.AddEnd(2);
            list2.AddEnd(3);
            list2.AddEnd(3);
            list2.AddEnd(3);

            bool areIdentical = list1.AreIdentical(list1, list2);
            Console.WriteLine();
            Console.WriteLine($"Are the lists identical? {areIdentical}");

            //method to remove duplicates from sorted linked list
            LinkedListQuestions linkedListDups = new LinkedListQuestions();
            linkedListDups.AddEnd(11);
            linkedListDups.AddEnd(22);
            linkedListDups.AddEnd(22);
            linkedListDups.AddEnd(33);
            linkedListDups.AddEnd(33);
            linkedListDups.AddEnd(44);

            Console.WriteLine();
            linkedListDups.RemoveDuplicates();
            Console.WriteLine();
            Console.WriteLine($"List after duplicate removal:");
            linkedListDups.PrintList();

            LinkedListQuestions midLinkedList = new LinkedListQuestions();
            midLinkedList.AddEnd(100);
            midLinkedList.AddEnd(200);
            midLinkedList.AddEnd(300);
            midLinkedList.AddEnd(400);
            midLinkedList.AddEnd(500);
            midLinkedList.AddEnd(600);

            //find middle node using ArrayList
            Node middleNode = midLinkedList.FindMiddleUsingArrayList();
            Console.WriteLine();
            Console.WriteLine($"Middle node linked list");
            midLinkedList.PrintList();
            Console.WriteLine($"Middle node: {middleNode.Data}");

            //stack operations
            Console.WriteLine();
            Console.WriteLine("Stack operations");
            Stack myStack = new Stack();
            StackOperation.PushToStack(myStack, new [] {11,22,33,44,55,66});
            Console.WriteLine($"Size of stack: {StackOperation.SizeOfStack(myStack)}");
            Console.WriteLine($"Top element of the stack: {StackOperation.PeekStack(myStack)}");
            StackOperation.PopAndPrintStack(myStack);
            bool isEmpty = StackOperation.IsStackEmpty(myStack);
            Console.WriteLine($"Is the stack empty? {isEmpty}");

            Console.ReadLine();
        }
    }
}
