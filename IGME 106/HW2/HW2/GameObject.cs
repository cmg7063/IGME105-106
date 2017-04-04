// Corinne Green
// 6 March 2016
// GameObject - A base class that establishes the base of the GameObjects Player() and Collectible()
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace HW2
{
    public class GameObject
    {
        // Attributes
        Texture2D objectSprite;
        Rectangle position;

        // GameObject parameterized constructor
        public GameObject(int x, int y, int width, int height)
        {
            // Set up the object's rectangle attribute
            position = new Rectangle(x, y, width, height);
        }

        // Properties
        public Texture2D ObjectSprite
        {
            get { return objectSprite; }
            set { objectSprite = value; }
        }

        public Rectangle Position
        {
            get { return position; }
            set { position = value; }
        }

        // A virtual method that Draws a spriteBatch object and can be overridden if need be
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(objectSprite, position, Color.White);
        }
    }
}
