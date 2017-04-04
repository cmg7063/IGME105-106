using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomQueue
{
	/// <summary>
	/// Implement this interface to act like a queue data structure
	/// </summary>
	interface IQueue
	{
		/// <summary>
		/// Gets whether or not the queue is empty (this implies
		/// that the List inside the queue is empty)
		/// </summary>
		bool IsEmpty { get; }

		/// <summary>
		/// Gets the number of things in the queue (which is exactly 
		/// the same as the number of things in the list)
		/// </summary>
		int Count { get; }

		/// <summary>
		/// Adds a string to the end of the queue
		/// </summary>
		/// <param name="str">The string to add</param>
		void Enqueue(String str);

		/// <summary>
		/// Remove the string at the beginning of the queue and return it
		/// </summary>
		/// <returns>The string that has been in the queue the longest</returns>
		String Dequeue();

		/// <summary>
		/// Returns the string at the beginning of the queue
		/// </summary>
		/// <returns>The string that has been in the queue the longest</returns>
		String Peek();
	}
}
