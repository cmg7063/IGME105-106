using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomStack
{
	/// <summary>
	/// Implement this interface to simulate a stack data structure
	/// </summary>
	interface IStack
	{
		/// <summary>
		/// Gets the number of strings in the stack.  This will not
		/// be directly tied to an attribute called "count"
		/// </summary>
		int Count { get; }

		/// <summary>
		/// Gets whether or not the stack is completely empty.
		/// Also not directly tied to an attribute.
		/// </summary>
		bool IsEmpty { get; }

		/// <summary>
		/// Add the string to the "top" (or end) of the stack
		/// </summary>
		/// <param name="str">The string to add</param>
		void Push(String str);

		/// <summary>
		/// Removes the data on top of the stack and returns it
		/// </summary>
		/// <returns>The most recently added string</returns>
		String Pop();

		/// <summary>
		/// Returns the data on top of the stack
		/// </summary>
		/// <returns>The most recently added string</returns>
		String Peek();
	}
}
