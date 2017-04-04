// Corinne Green
// 6 March 2016
// Collectible - A sub-class of GameObject that creates the collectible sprite, checks for a collision between the character and itself, and checks whether or not it is active
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace HW2
{
    class Collectible : GameObject
    {
        // Attributes
        bool active = true;    // Bool to determine whether or not the collectible is active or not; true by default

        // Collectible parameterized constructor
        public Collectible(int x, int y, int width, int height, bool active) : base(x, y, width, height)
        {
            this.active = active;
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        // Determines whether or not the gameObject and the Collectible have come into contact
        public bool CheckCollision(GameObject gameObject)
        {
            if (active && Position.Intersects(gameObject.Position))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Override GameObject's Draw() method
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (active)
            {
                spriteBatch.Draw(ObjectSprite, Position, Color.White);
            }
        }
    }
}
