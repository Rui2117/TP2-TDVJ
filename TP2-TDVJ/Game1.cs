using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
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
        public static int screenWidth = 1280, screenHeight = 720;
        private int nrLinhas = 0;
        private int nrColunas = 0;
        public bool started = false;

        public static Game Instance { get; private set; }

        //public const int tileSize = 64;
        private SpriteFont font;
        //private Texture2D player, enemy, platform;
        public char[,] level;

        public Camera camera;

        List<Objects> listOfObjects = new List<Objects>();
        List<Bullet> bullets= new List<Bullet>();
        public Player player;
        public Enemy enemy1, enemy2, enemy3, enemy4;
        public Platform platform, platform1, platform2, platform3, platform4, platform5, platform6, 
                        platform7, platform8, platform9, platform10, platform11, platform12, platform13,
                        platform14, platform15, platform16, platform17, platform18, platform19, platform20,
                        platform21, platform22, platform23, platform24, platform25, platform26, platform27,
                        platform28, platform29, platform30, platform31, platform32;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            Instance = this;
        }

        protected override void Initialize()
        {
            //TODO: Add your initialization logic here
            //LoadMap("Mapa1.txt");
            _graphics.PreferredBackBufferHeight = screenHeight;
            _graphics.PreferredBackBufferWidth = screenWidth;

            camera = new Camera();

            base.Initialize();
        }

        //protected void LoadMap(string map)
        //{
        //    string[] linhas = File.ReadAllLines($"Content/{map}");
        //    nrLinhas = linhas.Length;
        //    nrColunas = linhas[0].Length;
        //    Rectangle position = new Rectangle(0, 0, tileSize, tileSize); //calculo do retangulo a depender do tileSize
        //    for (int x = 0; x < nrColunas; x++) //pega a primeira dimensão
        //    {
        //        for (int y = 0; y < nrLinhas; y++) //pega a segunda dimensão
        //        {
                    
        //        }
        //    }

        //}

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            player = new Player(Content.Load<Texture2D>("guy"), new Vector2(10, 10), Content);

            enemy1 = new Enemy(Content.Load<Texture2D>("man-run_01"), new Vector2(600, 100));
            listOfObjects.Add(enemy1);
            enemy2 = new Enemy(Content.Load<Texture2D>("man-run_01"), new Vector2(1800, 200));
            listOfObjects.Add(enemy2);

            platform1 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(200, 300));
            listOfObjects.Add(platform1);
            platform2 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(300, 300));
            listOfObjects.Add(platform2);
            platform3 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(400, 300));
            listOfObjects.Add(platform3);
            platform4 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(500, 300));
            listOfObjects.Add(platform4);
            platform5 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(500, 200));
            listOfObjects.Add(platform5);
            platform6 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(600, 200));
            listOfObjects.Add(platform6);
            ///////////
            platform7 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(600, 300));
            listOfObjects.Add(platform7);
            platform8 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(900, 200));
            listOfObjects.Add(platform8);
            platform9 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(900, 300));
            listOfObjects.Add(platform9);
            platform10 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(1000, 300));
            listOfObjects.Add(platform10);

            platform11 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(1000, 200));
            listOfObjects.Add(platform11);
            platform12 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(1100, 200));
            listOfObjects.Add(platform12);
            platform13 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(1100, 300));
            listOfObjects.Add(platform13);
            platform14 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(1200, 300));
            listOfObjects.Add(platform14);
            platform15 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(1300, 300));
            listOfObjects.Add(platform15);
            platform16 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(1400, 300));
            listOfObjects.Add(platform16);
            platform17 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(1500, 300));
            listOfObjects.Add(platform17);
            platform18 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(1600, 300));
            listOfObjects.Add(platform18);
            platform19 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(1700, 300));
            listOfObjects.Add(platform19);
            platform20 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(1800, 300));
            listOfObjects.Add(platform20);

            platform21 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(1900, 300));
            listOfObjects.Add(platform21);
            platform22 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(2200, 300));
            listOfObjects.Add(platform22);
            platform23 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(2300, 300));
            listOfObjects.Add(platform23);
            platform24 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(2400, 200));
            listOfObjects.Add(platform24);
            platform25 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(2400, 300));
            listOfObjects.Add(platform25);
            platform26 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(2500, 200));
            listOfObjects.Add(platform26);
            platform27 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(2500, 300));
            listOfObjects.Add(platform27);
            platform28 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(2600, 200));
            listOfObjects.Add(platform28);
            platform29 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(2600, 300));
            listOfObjects.Add(platform29);
            platform30 = new Platform(Content.Load<Texture2D>("tile"), new Vector2(2700, 200));
            listOfObjects.Add(platform30);

            Sounds.LoadSounds(Content);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            KeyboardState currentKeyboardState = Keyboard.GetState();
            if (started==true)
            {
                double deltaTime = gameTime.ElapsedGameTime.TotalSeconds;
                if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                {
                    Exit();
                }
            
                player.UpdatePlayer(deltaTime, listOfObjects, bullets);

                foreach (Objects aux in listOfObjects)
                {
                    aux.Update(listOfObjects, bullets);
                }

                camera.Follow(player);
                // TODO: Add your update logic here

                base.Update(gameTime);
            }

            foreach (Bullet bullet in bullets)
            {
                bullet.Update(gameTime);
            }

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                started = true;
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin(transformMatrix: camera.Transform);
            // TODO: Add your drawing code here
            player.DrawPlayer(_spriteBatch);

            platform1.DrawPlatform(_spriteBatch);
            platform2.DrawPlatform(_spriteBatch);
            platform3.DrawPlatform(_spriteBatch);
            platform4.DrawPlatform(_spriteBatch);
            platform5.DrawPlatform(_spriteBatch);
            platform6.DrawPlatform(_spriteBatch);
            platform7.DrawPlatform(_spriteBatch);
            platform8.DrawPlatform(_spriteBatch);
            platform9.DrawPlatform(_spriteBatch);
            platform10.DrawPlatform(_spriteBatch);
            platform11.DrawPlatform(_spriteBatch);
            platform12.DrawPlatform(_spriteBatch);
            platform13.DrawPlatform(_spriteBatch);
            platform14.DrawPlatform(_spriteBatch);
            platform15.DrawPlatform(_spriteBatch);
            platform16.DrawPlatform(_spriteBatch);
            platform17.DrawPlatform(_spriteBatch);
            platform18.DrawPlatform(_spriteBatch);
            platform19.DrawPlatform(_spriteBatch);
            platform20.DrawPlatform(_spriteBatch);
            platform21.DrawPlatform(_spriteBatch);
            platform22.DrawPlatform(_spriteBatch);
            platform23.DrawPlatform(_spriteBatch);
            platform24.DrawPlatform(_spriteBatch);
            platform25.DrawPlatform(_spriteBatch);
            platform26.DrawPlatform(_spriteBatch);
            platform27.DrawPlatform(_spriteBatch);
            platform28.DrawPlatform(_spriteBatch);
            platform29.DrawPlatform(_spriteBatch);
            platform30.DrawPlatform(_spriteBatch);

            enemy1.DrawEnemy(_spriteBatch);
            enemy2.DrawEnemy(_spriteBatch);

            foreach (Bullet bullet in bullets)
            {
                bullet.Draw(_spriteBatch, player.position);
            }

            _spriteBatch.End();
            base.Draw(gameTime);            
        }
    }
}