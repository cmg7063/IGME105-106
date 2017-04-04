using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class GreenSquare : Enemy
    {
        private int backUp;
        private String response;
        private String shotAt;

        public GreenSquare()
        {
            this.shape = "Square";
            this.color = "Green";
          //  this.speed = 75;
        }

        public void BackOff(String response)
        {
            this.response = response;

            if (response == "shoot")
            {
                this.backUp = 10;
                Console.WriteLine("The Green Square has been shot and backed up " + backUp + " spaces.");
            }
            else
            {
                Console.WriteLine("The Green Square is chasing you!");
            }
        }
    }
}
