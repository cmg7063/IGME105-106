using System;

// NOTE: Since there is no Namespace, you will want to 
//       create a new file in your project called Node.cs,
//       and then copy everything from here down and paste
//       inside the Namespace in that file!

/// <summary>
/// Represents one node in a Linked List
/// </summary>
public class Node {
	
	// Attributes
	private String data;	// The data in this node
        private Node next;	// The next node in the list
        private Node previous;	// The previous node in the list

	/// <summary>
	/// Gets and sets the data of this node
	/// </summary>
	public String Data
	{
		get { return data; }
		set { data = value; }
	}

	/// <summary>
	/// Gets and sets the next node
	/// </summary>
	public Node Next
	{
		get { return next; }
		set { next = value; }
	}

	/// <summary>
	/// Gets and sets the previous node
	/// </summary>
	public Node Previous
	{
		get { return previous; }
		set { previous = value; }
	}

	/// <summary>
	/// Creates a new Node with data
	/// </summary>
	/// <param name="data">The data to hold in this node</param>
	public Node(String data)
	{
		this.data = data;
		this.next = null;
        this.previous = null;
	}

}




