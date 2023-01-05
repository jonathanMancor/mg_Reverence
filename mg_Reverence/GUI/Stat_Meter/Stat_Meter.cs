using mg_Reverence.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mg_Reverence.GUI.StatMeter
{
    internal class Stat_Meter : Component
    {
        internal string stat;
        internal string name;

        internal int max_value = 100;
        internal int current_value = 100;

        internal float scale = 0.9f;
        internal Vector2 pos;
        internal Rectangle bg_rect;
        internal Rectangle val_rect;

        internal Texture2D bg_tex;
        internal Texture2D val_tex;

        public Stat_Meter(Vector2 pos, Rectangle rect)
        {
            this.pos = pos;
            this.bg_rect = new Rectangle(0, 0, (int)(scale * max_value), 20);
            this.val_rect = new Rectangle(0, 0, (int)(scale * current_value), 18);

        }



        internal override void LoadContent(ContentManager Content)
        {
            throw new NotImplementedException();
        }

        internal override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        internal override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(bg_tex, pos, bg_rect, Color.White, 0f, new Vector2(0, 0), 1f, SpriteEffects.None, 1f);
            spriteBatch.Draw(val_tex, pos, val_rect, Color.White, 0f, new Vector2(0, 0), 1f, SpriteEffects.None, 1f);
        }
    }



    internal class Health_Meter : Stat_Meter
    {
        public Health_Meter(Vector2 pos, Rectangle rect) : base(pos, rect)
        {
            this.stat = "HP";
        }

        internal override void LoadContent(ContentManager Content)
        {
            bg_tex = Content.Load<Texture2D>("Test/squares/black_square");
            val_tex = Content.Load<Texture2D>("Test/squares/red_square");
        }
    }
}
