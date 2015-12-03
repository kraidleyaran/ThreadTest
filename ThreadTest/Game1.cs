using System;
using System.Drawing.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ButtonState = Microsoft.Xna.Framework.Input.ButtonState;
using Keys = Microsoft.Xna.Framework.Input.Keys;

namespace ThreadTest
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private IntPtr DrawingSurface;
        private Control GameForm;
        private Form ParentForm;
        private PictureBox PictureBox;

        public Game1(IntPtr drawingSurface, Form parentForm, PictureBox pictureBox)
        {
            DrawingSurface = drawingSurface;
            ParentForm = parentForm;
            PictureBox = pictureBox;

            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            int width = pictureBox.Width;
            int height = pictureBox.Height;
            graphics.PreparingDeviceSettings += graphics_PreparingDeviceSettings;
            graphics.PreferredBackBufferWidth = width;
            graphics.PreferredBackBufferHeight = height;
            GameForm = 
            /*
            GameForm.VisibleChanged += delegate(object sender, EventArgs args)
            {
                SetVisibleChanged(false);
            };
             */


        }
        
        private delegate void SetFormVisibleCallback(bool visible);

        private void SetVisibleChanged(bool visible)
        {
            if (GameForm.InvokeRequired)
            {
                SetFormVisibleCallback d = new SetFormVisibleCallback(SetVisibleChanged);
                GameForm.BeginInvoke(d, new object[] {visible});
            }
            else
            {
                GameForm.Visible = false;
            }
        }

        private delegate Control SetControlFromHandleCallback(IntPtr handle);
        private Control SetControlFromHandle(IntPtr handle)
        {
            if (GameForm.InvokeRequired)
            {
                SetControlFromHandleCallback d = new SetControlFromHandleCallback(SetControlFromHandle);
                GameForm.BeginInvoke(d, new object[] {handle});
            }
            else
            {
                return GameForm = Control.FromHandle(Window.Handle);
            }
        }
        private void graphics_PreparingDeviceSettings(object sender, PreparingDeviceSettingsEventArgs e)
        {
            e.GraphicsDeviceInformation.PresentationParameters.DeviceWindowHandle = DrawingSurface;
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

            // TODO: use this.Content to load your game content here
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
        }
    }
}
