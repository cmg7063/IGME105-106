using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the initial size of the list: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            CustomList customList = new CustomList(userInput);
            Console.WriteLine("Add a word to the list or enter a special command.");
            while (true)
            {
                String userInputList = Console.ReadLine().ToLower();
                Console.WriteLine();
                if (userInputList == "print")
                {
                    customList.Print();
                    Console.WriteLine();
                }
                if (userInputList == "get")
                {
                    Console.Write("Enter an index number: ");
                    int userIndex = Convert.ToInt32(Console.ReadLine());
                    customList.GetData(userIndex);
                }
                if (userInputList == "set")
                {
                    Console.Write("Enter a string and an index to be stored at the specified index: ");
                    String userString = Console.ReadLine();
                    int userIndex = Convert.ToInt32(Console.ReadLine());
                    customList.SetData(userIndex, userString);
                }
                if(userInputList == "done")
                {
                    break;
                }
                if (userInputList == "indexof")
                {
                    Console.Write("Enter the string you are looking for and if it exists, its index will be printed: ");
                    String userString = Console.ReadLine();
                    Console.WriteLine(customList.IndexOf(userString));
                }
                if (userInputList == "contains")
                {
                    Console.Write("Enter the string you are looking for and depending on its existence, true or false will be printed: ");
                    String userString = Console.ReadLine();
                    if (customList.Contains(userString) == false)
                    {
                        Console.WriteLine("That string does not appear to be in the list.");
                    }
                    else
                    {
                        Console.WriteLine("That string is in the list.");
                    }
                }
                if (userInputList == "removeat")
                {
                    Console.Write("Enter the index of the string you want removed: ");
                    int userIndex = Convert.ToInt32(Console.ReadLine());
                    customList.RemoveAt(userIndex);
                }
                if (userInputList == "remove")
                {
                    Console.Write("Enter the string you want to remove: ");
                    String userString = Console.ReadLine();
                    if (customList.Remove(userString) == false)
                    {
                        Console.WriteLine("Unsuccessfully removed.");
                    }
                    else
                    {
                        Console.WriteLine("Successfully removed.");
                    }
                }
                if (userInputList == "insert")
                {
                    Console.Write("Enter an index, then a string, and said string will be inserted in the list at the specified index: ");
                    int userIndex = Convert.ToInt32(Console.ReadLine());
                    String userString = Console.ReadLine();
                    customList.Insert(userIndex, userString);
                }
                if (userInputList == "clear")
                {
                    customList.Clear();
                    Console.WriteLine("The list has been cleared.");
                }
                // Is there a better way to do this?
                if (userInputList != "done" && userInputList != "set" && userInputList != "get" && userInputList != "print" && userInputList != "contains" && userInputList != "indexof" && userInputList != "removeat" && userInputList != "remove" && userInputList != "insert" && userInputList != "clear")
                {
                    customList.Add(userInputList);
                    Console.WriteLine(userInputList + " was successfully added to the list.");
                }
            }
        }
    }
}
