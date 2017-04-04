using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Your test code goes here - see requirements for Program.cs
            FileReader fileReader = new FileReader();
            Thread thread = new Thread(fileReader.ReadData);
            thread.Start();

            for (int i = 0; i < 100000; i++)
            {
                thread.Join();
            }

            Queue queue = fileReader.Queue;
            int totalVowels = 0;
            int commas = 0;
            int semiColon = 0;
            int period = 0;
            int hyphen = 0;
            int quote = 0;
            int leftParen = 0;
            int rightParen = 0;
            int question = 0;
            int totalConsonants = 0;
            while (queue.IsEmpty() == false)
            {
                string word = queue.Dequeue().ToLower();
                for (int i = 0; i < word.Length; i++)
                {
                    if (word.Substring(i ,1) == "a" || word.Substring(i, 1) == "e" || word.Substring(i, 1) == "i" || word.Substring(i, 1) == "o" || word.Substring(i, 1) == "u")
                    {
                        totalVowels++;
                    }
                    else if (word.Substring(i, 1) == " ")
                    {
                        return;
                    }
                    else if(word.Substring(i, 1) == ";")
                    {
                        commas++;
                    }
                    else if (word.Substring(i, 1) == ".")
                    {
                        period++;
                    }
                    else if (word.Substring(i, 1) == ";")
                    {
                        semiColon++;
                    }
                    else if (word.Substring(i, 1) == "-")
                    {
                        hyphen++;
                    }
                    else if (word.Substring(i, 1) == "'")
                    {
                        quote++;
                    }
                    else if (word.Substring(i, 1) == "(")
                    {
                        rightParen++;
                    }
                    else if (word.Substring(i, 1) == ")")
                    {
                        leftParen++;
                    }
                    else if (word.Substring(i, 1) == "?")
                    {
                        question++;
                    }
                    totalConsonants++;
                }
                
            }
                Console.WriteLine("There are " + totalVowels + " and " + totalConsonants + " in A Tale of Two Cities");
                Console.WriteLine(". : " + period);
                Console.WriteLine(", : " + commas);
                Console.WriteLine("; : " + semiColon);
                Console.WriteLine("- : " + hyphen);
                Console.WriteLine("( : " + rightParen);
                Console.WriteLine(") : " + leftParen);
                Console.WriteLine("? : " + question);
        }
    }
}
