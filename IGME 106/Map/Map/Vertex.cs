using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    class Vertex
    {
        // Attributes
        private string room;
        private int enemies;
        private int powerUp;
        private int loot;

        // Constructpr
        public Vertex(string room, int enemies, int powerUp, int loot)
        {
            this.room = room;
            this.enemies = enemies;
            this.powerUp = powerUp;
            this.loot = loot;
        }

        public override string ToString()
        {
            return "Name: " + room + " Enemies: " + enemies + " Power Ups: " + powerUp + " Loot: " + loot;
        }
    }
}
