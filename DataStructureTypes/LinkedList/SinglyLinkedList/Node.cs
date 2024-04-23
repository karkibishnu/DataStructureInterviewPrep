namespace DataStructureInterviewPrep.DataStructureTypes.LinkedList.SinglyLinkedList
{
// Define the Node class to represent a node in the linked list
public class Node
    {
        public int Data { get; set; }  // Property to store the data of the node
        public Node Next { get; set; } // Property to store a reference to the next node

        // Constructor to initialize a new node with the provided data
        public Node(int data)
        {
            Data = data;  // Set the data property
            Next = null;  // Initialize the Next property to null
        }
    }
}
