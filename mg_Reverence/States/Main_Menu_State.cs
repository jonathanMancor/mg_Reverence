using mg_Reverence.Core;
using mg_Reverence.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mg_Reverence.States
{
    internal class Main_Menu_State : Component
    {
        

        private Main_Menu_GUI GUI = new Main_Menu_GUI();
        


        internal override void LoadContent(ContentManager Content)
        {
            GUI.LoadContent(Content);
        }

        internal override void Update(GameTime gameTime)
        {
           GUI.Update(gameTime);
        }

        internal override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            GUI.Draw(spriteBatch);

            spriteBatch.End();
        }
    }
}
