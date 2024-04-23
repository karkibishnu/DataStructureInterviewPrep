using System;

namespace DataStructureInterviewPrep.DataStructureTypes.LinkedList.SinglyLinkedList
{
    // Define the LinkedList class to represent a singly linked list
    public class LinkedList
    {
        private Node head;  // Private member variable to store the first node (head) of the list

        // Constructor to initialize an empty linked list
        public LinkedList()
        {
            head = null;  // Initialize the head to null
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
