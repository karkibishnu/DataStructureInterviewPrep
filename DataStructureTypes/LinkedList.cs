using System;
using System.Collections.Generic;

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

        //method to add a node at the beginning of the linked list
        public void AddBeginning(int data)
        {
            Node newNode = new Node(data);

            if(head == null)
            {
                head = newNode;
                return;
            }

            newNode.Next = head;
            head = newNode;
        }

        //method to add a node in the middle of the linked list
        public void AddMiddle(int data, int position)
        {
            if(position < 0)
            {
                throw new ArgumentException("position cannot be negative");
            }

            Node newNode = new Node(data);

            if(position == 0)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }

            Node current = head;
            int currentPosition = 0;

            while(current != null && currentPosition < position - 1)
            {
                current = current.Next;
                currentPosition++;
            }

            if(current == null)
            {
                throw new ArgumentException("position out of range");
            }

            newNode.Next = current.Next;
            current.Next = newNode;
        }

        //method to check if a key 'X' is present in linked list using iterative approach
        public void SearchUsingIterativeApproach(int key)
        {
            Node current = head; //initialize a variable to traverse the list starting from the head

            while (current != null)
            {
                if(current.Data == key)
                {
                    Console.WriteLine($"Key with value {key} found");
                    return;
                }

                current = current.Next;
            }
            Console.WriteLine($"Key with value {key} not found");
        }

        //method check if a key 'X' is present in linked list using recursive approach
        // Method to search for a key in the linked list (Recursive Approach)
        public bool SearchRecursive(int key)
        {
            return SearchUsingRecursiveApproach(head, key);  // Call the helper method to perform the recursive search
        }

        // Helper method to perform the recursive search
        private bool SearchUsingRecursiveApproach(Node current, int key)
        {
            // Base case: If the current node is null, return false
            if (current == null)
            {
                return false;
            }

            // If the current node's data is equal to the key, return true
            if (current.Data == key)
            {
                return true;
            }

            // Recursive case: Search in the next node
            return SearchUsingRecursiveApproach(current.Next, key);
        }

        //method to count number of nodes in given singly linked list using iterative approach
        public int CountAvailableNodesIterative()
        {
            Node current = head;

            int nodesCounter = 0;
            if (current == null) return nodesCounter;

            while(current != null)
            {
                nodesCounter++;
                current = current.Next;
            }
            return nodesCounter;
        }

        // Method to count the number of nodes in the linked list (Recursive Approach)
        public int CountNodesRecursive()
        {
            return CountNodesRecursiveHelper(head);  // Call the helper method to perform the recursive count
        }

        // Helper method to perform the recursive count
        private int CountNodesRecursiveHelper(Node current)
        {
            // Base case: If the current node is null, return 0
            if (current == null)
            {
                return 0;
            }

            // Recursive case: Return 1 plus the count of nodes in the rest of the list
            return 1 + CountNodesRecursiveHelper(current.Next);
        }

        //method to reverse linked list 
        public void ReverseList()
        {
            Node prev = null, current = head, next = null;
            while(current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        // Method to reverse the linked list (Recursive Approach)
        public void ReverseRecursive()
        {
            head = ReverseRecursiveHelper(head);  // Call the helper method to perform the recursive reverse
        }

        // Helper method to perform the recursive reverse
        private Node ReverseRecursiveHelper(Node current)
        {
            // Base case: If the current node or the next node is null, return the current node
            if (current == null || current.Next == null)
            {
                return current;
            }

            // Recursive case: Reverse the rest of the list and set the next node's next reference to the current node
            Node rest = ReverseRecursiveHelper(current.Next);
            current.Next.Next = current;
            current.Next = null;

            return rest;
        }

        //method to reverse linked list using Stack
        public void ReverseWithStack()
        {
            if (head == null || head.Next == null)
            {
                return; //return if the list is empty or contains only one node
            }

            Stack<Node> stack = new Stack<Node>();//create a stack of Node type to store nodes

            //push all nodes onto the stack
            Node current = head;
            while(current != null)
            {
                stack.Push(current);
                current = current.Next;
            }

            //pop nodes from stack and update the next pointers to reverse the list
            head = stack.Pop();
            current = head;
            while(stack.Count > 0)
            {
                current.Next = stack.Pop();
                current = current.Next;
            }

            current.Next = null;
        }

        //method to delete from the beginning 
        public void DeleteBeginning()
        {
            if(head == null)
            {
                Console.WriteLine("Linked list is empty, cannot delete");
                return;
            }

            Node temp = head;
            head = head.Next;
            temp.Dispose();
        }

        //method to delete from the end
        public void DeleteEnd()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty, cannot delete");
                return;
            }

            if(head.Next == null)
            {
                head.Dispose(); //if there is only one node, delete it and set head to null
                head = null;
                return;
            }

            Node current = head;
            Node previous = null;

            while(current.Next != null)
            {
                previous = current;
                current = current.Next; // traverse to the last node
            }

            previous.Next = null; //update next pointer of the second last node to null
            current.Dispose(); //free memory of last node
        }

        //method to delete item from middle of the linked list based on key
        public void DeleteMiddle(int key)
        {
            //check if list is empty
            if(head == null)
            {
                Console.WriteLine($"List is empty, cannot delete");
                return;
            }

            //check if head node contains key
            if(head.Data == key)
            {
                Node temp = head; //store the reference to the head node
                head = head.Next; //update head to skip over the head node
                temp.Dispose(); //dispose head node to free its memory
                return;
            }

            Node current = head; //initialize current node to traverse the list
            Node previous = null; //initialize previous node to keep track of node before current node

            //traverse the list to find node with specified key
            while(current != null && current.Data != key)
            {
                previous = current; //update previous node to current node
                current = current.Next; //move to the next node
            }

            //check if key is not found in the list
            if(current == null)
            {
                Console.WriteLine($"Key {key} not found in the list");
                return;
            }

            //remove the node by updating next pointer of the previous node
            previous.Next = current.Next;
            //dispose of the node to free its memory
            current.Dispose();
        }

        //recursive method to delete a node from linked list based on key
        public void DeleteNodeByKeyRecursive(int key)
        {
            head = DeleteNodeByKeyRecursive(head, key);
        }

        private Node DeleteNodeByKeyRecursive(Node current, int key)
        {
            //base case: if current node is null, return null
            if(current == null) return null;

            //if current node contains key, delete it and return the next node
            if(current.Data == key)
            {
                Node temp = current.Next; //store next node
                current.Dispose(); //dispose current node
                return temp; //return next node
            }

            //recursively call method on the next node
            current.Next = DeleteNodeByKeyRecursive(current.Next, key);

            return current; //return current node after deletion
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
