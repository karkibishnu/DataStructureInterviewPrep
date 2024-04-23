using DataStructureInterviewPrep.DataStructureTypes.Arrays;
using DataStructureInterviewPrep.DataStructureTypes.Dictionary;
using DataStructureInterviewPrep.DataStructureTypes.LinkedList.SinglyLinkedList;
using System;

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
            ArraysConsole.Array2DExample();
            Console.WriteLine();

            //singly linked list adding and traversing
            LinkedList list = new LinkedList();  // Create a new linked list

            //adding nodes to linked list
            list.AddEnd(1);
            list.AddEnd(2);
            list.AddEnd(3);
            list.AddEnd(4);
            list.AddEnd(5);

            //printing the linked list
            list.PrintList();

            Console.ReadLine();
        }
    }
}
