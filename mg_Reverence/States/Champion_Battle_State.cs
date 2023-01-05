using mg_Reverence.Core;
using mg_Reverence.GUI;
using mg_Reverence.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mg_Reverence.States
{
    internal class Champion_Battle_State : Component
    {
        Champion_Battle_GUI _GUI;
        //Camera camera;
        //InputManager input;



        

        internal override void LoadContent(ContentManager Content)
        {

            //camera = new Camera();
            //input = new InputManager();
            _GUI = new Champion_Battle_GUI();

            _GUI.LoadContent(Content);


            //map.LoadContent(Content);
            //playerParty.LoadContent(Content);
            //playerParty.SetPosition(map.camp.position);
            //Console.WriteLine(map.tiles.Count);
            
        }

        internal override void Update(GameTime gameTime)
        {
            //_GUI.Update(gameTime);
            //camera.Update(playerParty);
            

            //Console.WriteLine(playerParty.isCollide[0] +"|"+ playerParty.isCollide[1] + "|" + playerParty.isCollide[2] + "|" + playerParty.isCollide[3]);
            
           
            //input.KeyboardController(playerParty, gameTime);
            
        }

        internal override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin(/*transformMatrix: camera.transform*/);

            _GUI.Draw(spriteBatch);
            //map.Draw(spriteBatch);
            //playerParty.Draw(spriteBatch);
            
            
            spriteBatch.End();
        }
    }
}
