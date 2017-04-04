using System;

// NOTE: Since there is no Namespace, you will want to 
//       create a new file in your project called IList.cs,
//       and then copy everything from here down and paste
//       inside the Namespace in that file!

/// <summary>
/// The interface for a simple Linked List
/// </summary>
public interface IList
{
	// Add a new element to the end of the list.
	void Add(String data);

	// Inserts a new element at a specified location in the list.
	void Insert(String data, int index);

	// Remove an element from a specified location in 
	// the list and return the data
	String Remove(int index);

	// Return the element at this index in the list.
	String GetElement(int index);

	// Clears the list
	void Clear();

	// The current number of items in this list.
	int Count { get; }

} 
