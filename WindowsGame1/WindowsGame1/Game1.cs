using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace ErichGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont font;

        DisplayText score1Lbl = new DisplayText(new Vector2(0,0), "SCORE<1>");
        DisplayText hiScoreLbl = new DisplayText(new Vector2(0,0), "HI-SCORE");
        DisplayText score2Lbl = new DisplayText(new Vector2(0,0), "SCORE<2>");
        DisplayText player1Score = new DisplayText(new Vector2(0,0), "0000");
        DisplayText highScore = new DisplayText(new Vector2(0,0), "0000");
        DisplayText player2Score = new DisplayText(new Vector2(0,0), "0000");
        //Sprite alien = new Sprite(new Vector2(0,0), ????);
        //Sprite shield =  new Sprite(new Vector2(0,0), ????);
        //Sprite player = new Sprite(new Vector2(0,0), ????);
        DisplayText numLives = new DisplayText(new Vector2(0,0), "3");
        //Sprite shipLifeIcon = new Sprite(new Vector2(0,0), ????);
        DisplayText creditLbl = new DisplayText(new Vector2(0,0), "CREDIT");
        DisplayText numCredit = new DisplayText(new Vector2(0,0), "00");
        //Sprite ufo = new Sprite(new Vector2(0,0), ????);
        //Sprite alienBullet = new Sprite(new Vector2(0,0), ????);
        //Sprite playerBullet = new Sprite(new Vector2(0,0), ????);

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 224;
            graphics.PreferredBackBufferHeight = 256;
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

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            font = Content.Load<SpriteFont>("SpaceFont");

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
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
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.DrawString(font, "TEST", new Vector2(2, 2), Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
