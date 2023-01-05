using mg_Reverence.Core;
using mg_Reverence.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mg_Reverence.Managers
{
    internal partial class StateManager : Component
    {

        private Main_Menu_State main_menu_state = new Main_Menu_State();
        private Champion_Battle_State champion_battle_state = new Champion_Battle_State();

        internal override void LoadContent(ContentManager Content)
        {
            main_menu_state.LoadContent(Content);
            champion_battle_state.LoadContent(Content);
        }

        internal override void Update(GameTime gameTime)
        {
            switch (Data.CurrentState)
            {
                case Data.State.Main_menu:
                    main_menu_state.Update(gameTime);
                    break;
                case Data.State.Settings:
                    break;
                case Data.State.Champion_battle:
                    champion_battle_state.Update(gameTime);
                    break;
                
            }
        }

        internal override void Draw(SpriteBatch spriteBatch)
        {
            switch (Data.CurrentState)
            {
                case Data.State.Main_menu:
                    main_menu_state.Draw(spriteBatch);
                    break;
                case Data.State.Settings:
                    break;
                case Data.State.Champion_battle:
                    champion_battle_state.Draw(spriteBatch);
                    break;
                
            }
        }
    }
}
