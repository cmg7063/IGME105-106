using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsReturnStatements
{
    class Map
    {
        public int width;
        public int height;
        public double size;

        public Map()
        {
           // size = 
        }

        public int CalculateTotalArea()
        {
            int area = width * height;
            return area;
        }

        public double CalculateGrassArea()
        {
            double grassArea = (CalculateTotalArea() * .7);
            return grassArea;
        }

        public double CalculateMaxMonsters()
        {
            this.size = CalculateGrassArea();
            int monsterSize = (int)size;
            return monsterSize;
        }
    }
}
