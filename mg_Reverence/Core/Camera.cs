using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace mg_Reverence.Core
{
    internal class Camera
    {


        public Vector2 position;
        public Matrix transform { get; private set; }
        //public float delay { get; set; }

        public Camera()
        {
            this.position = new Vector2(0,0);
        }

        /*public void Update(Party e)
        {
            //float d = (float)gameTime.ElapsedGameTime.TotalMilliseconds / 5;
            this.position.X += e.position.X - position.X - Data.ScreenWidth / 2;
            this.position.Y += e.position.Y - position.Y - Data.ScreenHeight / 2;

            transform = Matrix.CreateTranslation(-position.X, -position.Y, 0);
        }*/


        /*public void Follow(Party target)
        {
            var offset = Matrix.CreateTranslation(Data.ScreenWidth / 2, Data.ScreenHeight / 2, 0);

            var position = Matrix.CreateTranslation(-target.position.X - (target.collider.Width / 2),
                -target.position.Y - (target.collider.Height / 2),
                0);
            
            transform = position * offset;
        }*/








        //////////////////////////////////////////////////////////////////////////////////
        /*public Matrix Transform { get; private set; }

        public void Focus(Entity target)
        {

            var position = Matrix.CreateTranslation(
                target.position.X + (target.collider.Width / 2),
                target.position.Y + (target.collider.Height / 2),
                0);
            var offset = Matrix.CreateTranslation(
                Data.ScreenWidth / 2,
                Data.ScreenHeight / 2,
                0);

            //Transform = position * offset;
            Transform = position;
        }*/
    }
}
