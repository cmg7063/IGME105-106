// Corinne Green
// 6 March 2016
// Game - A class that handles the actual implementation of the game: Updating the screen, drawing gameObjects, etc.
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace HW2
{

    enum GameState { Menu, Game, GameOver };

    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // Additional attributes
        GameState gameState;
        Texture2D background;
        Texture2D playerSprite;
        Texture2D collectibleSprite;
        Vector2 backgroundPos;
        SpriteFont spriteFont;
        Player player;
        List <Collectible> collectibleList;
        int currentLevel;
        double timer;
        KeyboardState kbState;
        KeyboardState previousKbState;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            backgroundPos = new Vector2(0, 0);
            player = new Player(0, 0, 70, 146, 0, 0);
            collectibleList = new List<Collectible>();
            gameState = GameState.Menu;     // Set the initial state of the game
            IsMouseVisible = true;  // Makes the mouse visible in the window
            base.Initialize();
        }

        // Set up each level the player encounters
        public void NextLevel()
        {
            collectibleList.Clear();
            currentLevel++;
            timer = 10;
            player.LevelScore = 0;
            player.Position = new Rectangle(GraphicsDevice.Viewport.Width / 2, GraphicsDevice.Viewport.Height / 2, player.Position.Width, player.Position.Height);

            // Random number generator that will help generate a random position of the collectible sprite
            Random rng = new Random();
            for (int i = 0; i < currentLevel * rng.Next(1, 20); i++)
            {
                Collectible collectible = new Collectible(rng.Next(0, GraphicsDevice.Viewport.Width), rng.Next(0, GraphicsDevice.Viewport.Height), 70, 91, true);
                collectible.ObjectSprite = collectibleSprite;
                CollectibleBounds(collectible);
                collectibleList.Add(collectible);
            }
        }
        // To prevent the Collectible objects from generating outside of the window I created a modified ScreenWrap() method
        public void CollectibleBounds(GameObject gameObject)
        { 
            if (gameObject.Position.X > Window.ClientBounds.Width - gameObject.ObjectSprite.Width)
            {
                gameObject.Position = new Rectangle (Window.ClientBounds.Width - gameObject.ObjectSprite.Width, gameObject.Position.Y, gameObject.Position.Width, gameObject.Position.Height);
            }
            if (gameObject.Position.Y > Window.ClientBounds.Height - gameObject.ObjectSprite.Height)
            {
                gameObject.Position = new Rectangle(gameObject.Position.X, Window.ClientBounds.Height - gameObject.ObjectSprite.Height, gameObject.Position.Width, gameObject.Position.Height);
            }
            if (gameObject.Position.X < 0)
            {
                gameObject.Position = new Rectangle(0, gameObject.Position.Y, gameObject.Position.Width, gameObject.Position.Height);
            }
            if (gameObject.Position.Y < 0)
            {
                gameObject.Position = new Rectangle(gameObject.Position.X, 0, gameObject.Position.Width, gameObject.Position.Height);
            }
        }

        // Sets up the initial values for the game
        public void ResetGame()
        {
            currentLevel = 0;
            player.TotalScore = 0;
            NextLevel();
        }

        // Keeps the object (Player) on the screen at all times
        public void ScreenWrap(GameObject gameObject)
        {
            if (gameObject.Position.X < -gameObject.Position.Width)
            {
                gameObject.Position = new Rectangle(GraphicsDevice.Viewport.Width + gameObject.Position.X, gameObject.Position.Y, gameObject.Position.Width, gameObject.Position.Height);
            }
            if (gameObject.Position.X > GraphicsDevice.Viewport.Width)
            {
                gameObject.Position = new Rectangle(GraphicsDevice.Viewport.Width - gameObject.Position.X, gameObject.Position.Y, gameObject.Position.Width, gameObject.Position.Height);
            }
            if (gameObject.Position.Y < -gameObject.Position.Height)
            {
                gameObject.Position = new Rectangle(gameObject.Position.X, GraphicsDevice.Viewport.Height + gameObject.Position.Y, gameObject.Position.Width, gameObject.Position.Height);
            }
            if (gameObject.Position.Y > GraphicsDevice.Viewport.Height)
            {
                gameObject.Position = new Rectangle(gameObject.Position.X, GraphicsDevice.Viewport.Height - gameObject.Position.Y, gameObject.Position.Width, gameObject.Position.Height);
            }
        }

        // Returns true if this is the first time that the key was pressed and false otherwise
        public bool SingleKeyPress(Keys key)
        {
            if (kbState.IsKeyDown(key) && previousKbState.IsKeyUp(key))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            background = Content.Load<Texture2D>("Background");
            playerSprite = Content.Load<Texture2D>("Sophie");
            collectibleSprite = Content.Load<Texture2D>("Collectible");
            spriteFont = Content.Load<SpriteFont>("SpriteFont1");

            // Set the Player's texture
            player.ObjectSprite = playerSprite;
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            previousKbState = kbState;
            kbState = Keyboard.GetState();

            // Finite machine for GameStates
            switch (gameState)
            {
                case GameState.Menu:
                    if (SingleKeyPress(Keys.Enter))
                    {
                        gameState = GameState.Game;
                        ResetGame();
                    }
                    break;
                case GameState.Game:
                    timer -= gameTime.ElapsedGameTime.TotalSeconds;
                    if (kbState.IsKeyDown(Keys.W))
                    {
                        player.Position = new Rectangle(player.Position.X, player.Position.Y - 3, player.Position.Width, player.Position.Height);
                    }
                    if (kbState.IsKeyDown(Keys.A))
                    {
                        player.Position = new Rectangle(player.Position.X - 3, player.Position.Y, player.Position.Width, player.Position.Height);
                    }
                    if (kbState.IsKeyDown(Keys.S))
                    {
                        player.Position = new Rectangle(player.Position.X, player.Position.Y + 3, player.Position.Width, player.Position.Height);
                    }
                    if (kbState.IsKeyDown(Keys.D))
                    {
                        player.Position = new Rectangle(player.Position.X + 3, player.Position.Y, player.Position.Width, player.Position.Height);
                    }
                    ScreenWrap(player);
                   
                    foreach(Collectible collectible in collectibleList)
                    {
                        if (collectible.CheckCollision(player))
                        {
                            collectible.Active = false;
                            player.LevelScore++;
                            player.TotalScore++;
                        }
                    }

                    if (timer <= 0)
                    {
                        gameState = GameState.GameOver;
                    }

                    if (player.LevelScore == collectibleList.Count)
                    {
                        NextLevel();
                    }
                    break;

                case GameState.GameOver:
                    if (SingleKeyPress(Keys.Enter))
                    {
                        gameState = GameState.Menu;
                    }
                    break;
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
            spriteBatch.Begin();
            spriteBatch.Draw(background, backgroundPos, Color.White);

            if (gameState == GameState.Game)
            {
                for(int i = 0; i < collectibleList.Count; i++)
                {
                    collectibleList[i].Draw(spriteBatch);
                }
                player.Draw(spriteBatch);
                spriteBatch.DrawString(spriteFont, "Current Level: " + currentLevel, new Vector2(0.0f, 0.0f), Color.Black);
                spriteBatch.DrawString(spriteFont, "Level Score: " + player.LevelScore, new Vector2(0.0f, 20.0f), Color.Black);
                spriteBatch.DrawString(spriteFont, String.Format("{0: 0.00}", timer), new Vector2(0.0f, 40.0f), Color.Black);
            }
            if (gameState == GameState.GameOver)
            {
                spriteBatch.DrawString(spriteFont, "Game Over", new Vector2(360.0f, 150.0f), Color.Black);
                spriteBatch.DrawString(spriteFont, "Current Level: " + currentLevel, new Vector2(350.0f, 190.0f), Color.Black);
                spriteBatch.DrawString(spriteFont, "Total Score: " + player.TotalScore, new Vector2(350.0f, 210.0f), Color.Black);
                spriteBatch.DrawString(spriteFont, "Press 'Enter' to return to the main menu", new Vector2(250.0f, 230.0f), Color.Black);
            }
            if (gameState == GameState.Menu)
            {
                spriteBatch.DrawString(spriteFont, "Sophie and Turnip Head's Adventure", new Vector2(250.0f, 150.0f), Color.Black);
                spriteBatch.DrawString(spriteFont, "Instructions: Collect all the Turnip Heads to progress to the next level", new Vector2(150.0f, 190.0f), Color.Black);
                spriteBatch.DrawString(spriteFont, "To start the game press 'Enter'", new Vector2(250.0f, 210.0f), Color.Black);
            }
            spriteBatch.End();
        }
    }
}
