using DataStructureInterviewPrep.DataStructureTypes.LinkedList.SinglyLinkedList;
using System;
using System.Collections;

namespace DataStructureInterviewPrep.DataStructureTypes.LinkedList.SinglyLinkedList
{
    public class LinkedListQuestions
    {
        private Node head; // private member variable to store the first node (head) of the list 

        // constructor to initialize an empty linked list
        public LinkedListQuestions()
        {
            head = null;
        }

        // Method to add a node at the end of the linked list
        public void AddEnd(int data)
        {
            Node newNode = new Node(data);  // Create a new node with the provided data

            // Check if the list is empty
            if (head == null)
            {
                head = newNode;  // If empty, set the head to the new node
                return;          // Exit the method
            }

            Node current = head;  // Initialize a variable to traverse the list starting from the head

            // Iterate through the list until the last node is reached
            while (current.Next != null)
            {
                current = current.Next;  // Move to the next node
            }

            current.Next = newNode;  // Add the new node at the end of the list
        }

        //method to check if two linked list are identical
        public bool AreIdentical(LinkedListQuestions list1, LinkedListQuestions list2)
        {
            Node current1 = list1.head; //initialize current node for the first list
            Node current2 = list2.head; //initialize current node for second list

            //traverse both lists and compare each node's data
            while(current1 != null & current2 != null)
            {
                if(current1.Data != current2.Data)
                {
                    return false;
                }

                //move to the next node in both sides
                current1 = current1.Next;
                current2 = current2.Next;
            }

            if(current1 != null || current2 != null)
            {
                return false;
            }
            return true;
        }

        //method to remove duplicates from sorted linked list
        public void RemoveDuplicates()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node current = head;

            //traverse the list
            while(current != null && current.Next != null)
            {
                //compare current node's data with next node's data
                if(current.Data == current.Next.Data)
                {
                    //remove next node by adjusting pointers
                    current.Next = current.Next.Next;
                }
                else
                {
                    //move to the next node
                    current = current.Next;
                }
            }
        }

        //method to find middle node using arraylist
        public Node FindMiddleUsingArrayList()
        {
            //check if list is empty
            if(head == null)
            {
                Console.WriteLine("List is empty");
                return null;
            }

            //create ArrayList to store node values
            ArrayList listValues = new ArrayList();

            Node current = head;

            //traverse list and store node values in ArrayList
            while(current != null)
            {
                listValues.Add(current.Data);
                current = current.Next;
            }

            //calculate middle index
            int middleIndex = listValues.Count / 2;
            Console.WriteLine($"middle index: {middleIndex}");

            //retrieve middle value from ArrayList
            int middleValue = (int)listValues[middleIndex];

            //print middle value
            Console.WriteLine($"Middle value of the linked list: {middleValue}");
            return new Node(middleValue);
        }

        // Method to traverse and print the linked list
        public void PrintList()
        {
            Node current = head;  // Initialize a variable to traverse the list starting from the head

            // Iterate through the list until the end (null) is reached
            while (current != null)
            {
                Console.Write(current.Data + " -> ");  // Print the data of the current node
                current = current.Next;  // Move to the next node
            }

            Console.WriteLine("null");  // Print "null" to indicate the end of the list
        }
    }
}
