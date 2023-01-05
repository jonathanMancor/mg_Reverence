using mg_Reverence.Core;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace mg_Reverence.GUI
{
    internal class Champion_Battle_GUI : Component
    {
        SideMenu sideMenu = new SideMenu();
        ActionMenu actionMenu = new ActionMenu();
        BattleScene battleScene;


        

        internal override void LoadContent(ContentManager Content)
        {
            sideMenu.LoadContent(Content);
            actionMenu.LoadContent(Content);
        }

        internal override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        internal override void Draw(SpriteBatch spriteBatch)
        {
            
            actionMenu.Draw(spriteBatch);
            sideMenu.Draw(spriteBatch);
        }
    }


    // SIDE MENU ================================================================ //
    internal class SideMenu : Component
    {
        Texture2D texture;
        Vector2 position;
        Rectangle source;

        


        //class
        // lvl

        //HP meter
        //MRL meter

        //equipment slots
        //inventory

        //stats

        public SideMenu()
        {
            source = new Rectangle(0,0,192, Data.ScreenHeight);
            position = new Vector2(Data.ScreenWidth - source.Width,0);
        }
        internal override void LoadContent(ContentManager Content)
        {
            texture = Content.Load<Texture2D>("Test/white_screen");
            font = Content.Load<SpriteFont>(Data.Arial12);
        }

        internal override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        internal override void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Draw(texture, position, source, Color.White, 0f, new Vector2(0, 0), 1f, SpriteEffects.None, 1f);
            spriteBatch.DrawString(font, class_name, new Vector2(0,0), Color.White, 0f, new Vector2(0, 0), 1f, SpriteEffects.None, 1f);
        }
    }

    internal class Current_Champion_Info : Component
    {
        string current_champion;
        //champion portrait
        Texture2D portrait_texture;
        Vector2 portrait_position;
        Rectangle portrait_source;

        //info
        SpriteFont font;
        string name;
        string class_name;
        int level;

        public Current_Champion_Info(/*string name, string class_name, string level*/)
        {


            this.name = "Jon";
            this.class_name = "rogue";
            this.level = 1;
        }

        internal string LevelString(int value)
        {
            return value.ToString();
        }

        internal override void LoadContent(ContentManager Content)
        {
            texture = Content.Load<Texture2D>("Test/white_square");
            font = Content.Load<SpriteFont>(Data.Arial12);
        }

        internal override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
        internal override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }



    // ACTION MENU ================================================================ //
    internal class ActionMenu : Component
    {
        //stance
        //Action
        //output
        Texture2D texture;
        Vector2 position;
        Rectangle source;

        public ActionMenu()
        {
            source = new Rectangle(0, 0, Data.ScreenWidth, 192);
            position = new Vector2(0, Data.ScreenHeight - source.Height);
        }
        internal override void LoadContent(ContentManager Content)
        {
            texture = Content.Load<Texture2D>("Test/white_screen");
        }

        internal override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        internal override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, source, Color.GreenYellow, 0f, new Vector2(0, 0), 1f, SpriteEffects.None, 1f);
        }

    }







    // BATTLE SCENE ================================================================ //
    internal class BattleScene : Component
    {
        //champion slots
        //morale meter
        List<Champion_Slot> slot_list = new List<Champion_Slot>();
        TestChampionData slot_data = new TestChampionData();

        

        internal override void LoadContent(ContentManager Content)
        {
            slot_list = LoadSlotData(Content);

            foreach (Champion_Slot slot in slot_list)
            {
                slot.LoadChampionSLots(Content);
            }
        }
        internal override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
        internal List<Champion_Slot> LoadSlotData(ContentManager Content)
        {
            Champion_Slot tmpSlot;


            slot_list.Add(tmpSlot = new Champion_Slot(0, slot_data.name_0, slot_data.img_file_0));
            slot_list.Add(tmpSlot = new Champion_Slot(1, slot_data.name_1, slot_data.img_file_1));
            slot_list.Add(tmpSlot = new Champion_Slot(2, slot_data.name_2, slot_data.img_file_2));
            slot_list.Add(tmpSlot = new Champion_Slot(3, slot_data.name_3, slot_data.img_file_3));
            return slot_list;
        }
        internal override void Draw(SpriteBatch spriteBatch)
        {
            foreach (Champion_Slot slot in slot_list)
            {
                spriteBatch.Draw(slot.texture, slot.pos, slot.rect, Color.White, 0f, new Vector2(0, 0), 1f, SpriteEffects.None, 1f);
            }
        }

        
    }
    internal class Champion_Slot
    {
        int id;
        string name;

        internal Vector2 pos;
        internal Rectangle rect = new Rectangle(0,0, 100, 200);
        internal float margin = 16f;

        string img_file;
        internal Texture2D texture;

        public Champion_Slot(int id, string name, string img_file)
        {
            this.id = id;
            this.name = name;
            this.img_file = img_file;
            
            
        }
        internal void LoadChampionSLots(ContentManager Content)
        {
            texture = Content.Load<Texture2D>(img_file);
            pos = new Vector2((rect.Width + margin) * id, 0);
        }
        
        
    }

    
}
