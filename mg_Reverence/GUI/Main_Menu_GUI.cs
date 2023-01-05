using mg_Reverence.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mg_Reverence.GUI
{
    internal class Main_Menu_GUI : Component
    {
        //btn variables
        private const int btnCount = 3;
        private Texture2D[] btns = new Texture2D[btnCount];
        private Rectangle[] btnRects = new Rectangle[btnCount];

        //mouse variables
        private MouseState mouseState, PrevMouseState;
        private Rectangle mouseRect;


        internal override void LoadContent(ContentManager Content)
        {
            int incVal = 125;
            for (int i = 0; i < btnCount; i++)
            {
                btns[i] = Content.Load<Texture2D>($"Test/btn_{i}");
                btnRects[i] = new Rectangle(0, 0 + (incVal * i), btns[i].Width / 2, btns[i].Height / 2);
            }
        }

        internal override void Update(GameTime gameTime)
        {
            PrevMouseState = mouseState;
            mouseState = Mouse.GetState();
            mouseRect = new Rectangle(mouseState.X, mouseState.Y, 1, 1);

            if (mouseState.LeftButton == ButtonState.Pressed && mouseRect.Intersects(btnRects[0]))
            {
                Data.CurrentState = Data.State.Champion_battle;
            }
            if (mouseState.LeftButton == ButtonState.Pressed && mouseRect.Intersects(btnRects[2]))
            {
                Data.Exit = true;
            }
        }

        internal override void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < btnCount; i++)
            {
                spriteBatch.Draw(btns[i], btnRects[i], Color.White);

                if (mouseRect.Intersects(btnRects[i]))
                {
                    spriteBatch.Draw(btns[i], btnRects[i], Color.Red);
                }
            }
        }
    }
}
