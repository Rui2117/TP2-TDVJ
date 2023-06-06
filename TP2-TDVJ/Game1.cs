using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Reflection.Emit;
using Vector2 = Microsoft.Xna.Framework.Vector2;

namespace TP2_TDVJ
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private int nrLinhas = 0;
        private int nrColunas = 0;
        private int tileSize = 64;
        private SpriteFont font;
        public char[,] level;

        List<Objects> listOfObjects = new List<Objects>();
        public Player player;
        public Platform platform1;
        public Platform platform2;
        public Platform platform3;
        public Platform platform4;
        public Platform platform5;
        public Platform platform6;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            //LoadMap("Mapa1.txt");
            base.Initialize();
        }

        //protected void LoadMap(string map)
        //{
        //    string[] linhas = File.ReadAllLines($"Content/{map}");
        //    nrLinhas = linhas.Length;
        //    nrColunas = linhas[0].Length;
        //    Rectangle position = new Rectangle(0, 0, tileSize, tileSize); //calculo do retangulo a depender do tileSize
        //    for (int x = 0; x < level.GetLength(0); x++) //pega a primeira dimensão
        //    {
        //        for (int y = 0; y < level.GetLength(1); y++) //pega a segunda dimensão
        //        {
        //            position.X = x * tileSize; // define o position
        //            position.Y = y * tileSize; // define o position
        //            switch (level[x, y])
        //            {
        //                case 'X':
        //                    platform.DrawPlatform(_spriteBatch, position);
        //                    break;
        //            }
        //        }
        //    }

        //}

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            player = new Player(Content.Load<Texture2D>("guy"), new Vector2(10,10));
            
            platform1 = new Platform(Content.Load<Texture2D>("tile"), 100, 100, new Vector2(200, 300));
            listOfObjects.Add(platform1);
            platform2 = new Platform(Content.Load<Texture2D>("tile"), 100, 100, new Vector2(300, 300));
            listOfObjects.Add(platform2);
            platform3 = new Platform(Content.Load<Texture2D>("tile"), 100, 100, new Vector2(400, 300));
            listOfObjects.Add(platform3);
            platform4 = new Platform(Content.Load<Texture2D>("tile"), 100, 100, new Vector2(500, 300));
            listOfObjects.Add(platform4);
            platform5 = new Platform(Content.Load<Texture2D>("tile"), 100, 100, new Vector2(500, 200));
            listOfObjects.Add(platform5);
            platform6 = new Platform(Content.Load<Texture2D>("tile"), 100, 100, new Vector2(600, 200));
            listOfObjects.Add(platform6);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            double deltaTime = gameTime.ElapsedGameTime.TotalSeconds;
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            
            player.UpdatePlayer(deltaTime, listOfObjects);
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            // TODO: Add your drawing code here
            player.DrawPlayer(_spriteBatch);
            platform1.DrawPlatform(_spriteBatch);
            platform2.DrawPlatform(_spriteBatch);
            platform3.DrawPlatform(_spriteBatch);
            platform4.DrawPlatform(_spriteBatch);
            platform5.DrawPlatform(_spriteBatch);
            platform6.DrawPlatform(_spriteBatch);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}