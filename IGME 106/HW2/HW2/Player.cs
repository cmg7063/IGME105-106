// Corinne Green
// 6 March 2016
// Player - A sub-class of GameObject that contains the attributes levelScore and totalScore of the player
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace HW2
{
    class Player : GameObject
    {
        // Attributes
        int levelScore;     // The score of the current level
        int totalScore;     // The player's total score since starting the game

        // Player parameterized constructor
        public Player(int x, int y, int width, int height, int levelScore, int totalScore) : base(x, y, width, height)
        {
            this.levelScore = levelScore;
            this.totalScore = totalScore;
        }

        public int LevelScore
        {
            get { return levelScore; }
            set { levelScore = value; }
        }
        public int TotalScore
        {
            get { return totalScore; }
            set { totalScore = value; }
        }

    }
}
