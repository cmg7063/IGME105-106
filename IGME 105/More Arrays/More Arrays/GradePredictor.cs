using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Arrays
{
    class GradePredictor
    {
        public int[] GetLetters(String userName)
        {
            //Creating an array that will hold the 3 values that determine grade
            int[] threeLetters = new int[3];

            char firstLetter = userName[0];
            threeLetters[0] = userName[0];
            char thirdLetter = userName[2];
            threeLetters[1] = userName[2];
            char fifthLetter = userName[4];
            threeLetters[2] = userName[4];

            if(userName.Length < 5)
            {
                threeLetters = new int[0];
            }

            return threeLetters;
        }

        public int EstimateGrade(int[] threeLetters)
        {
            int sum = (threeLetters[0] + threeLetters[1] + threeLetters[2]) * 85;
            int result = sum % 101;
            return result;
        }

        public String AssignGrade(int result)
        {
            if (result >= 90)
            {
                return "A";
            }
            else if ((result >= 80 && result <= 89))
            {
                return "B";
            }
            else if ((result >= 70 && result <= 79))
            {
                return "C";
            }
            else if ((result >= 60 && result <= 69))
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
