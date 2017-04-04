using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Corinne Green
// 27 February 2016
// TestFileData - A class that contains the Main method and will drive all of the testing

namespace Exam1BaseCode
{
    class TestFileData
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path to the file: ");
            string filePath = Console.ReadLine();

            // This handles the instance if the file is not found.
            try
            {
                FileData fileData = new FileData(filePath);
                fileData.Analyze();
                fileData.Display();
            }
            catch (FileNotFoundException fnf)
            {
                Console.WriteLine("Could not find a part of the path " + filePath + fnf.Message);
            }

            /*--------------------------------------------*/
            // DO NOT CHANGE OR ADD CODE AFTER THIS POINT
            string endText = Console.ReadLine();  // stop execution
        }
    }
}
