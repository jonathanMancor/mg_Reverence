using mg_Reverence.Champion_Battle.Class_Types;
using mg_Reverence.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mg_Reverence.Champion_Battle.Champions
{
    internal class Champion : Component
    {
        int id;
        string name;
        string description;
        ClassType classType;
        Texture2D portrait_tex;
        Texture2D image_tex;
        //ChampionStances stances;



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
            throw new NotImplementedException();
        }
    }
}
