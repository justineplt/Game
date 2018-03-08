using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Escape_numericGame
{
    class BarreVie : Objet2D
    {
        public BarreVie(Game game, string chemin, Vector2 taille) : base(game, chemin, taille)
        {
        }

        public override void Initialize()
        {
            this.position = new Vector2(10,10);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            base.LoadContent();
        }

        public override void Draw(GameTime gameTime)
        {
            myGame.GetSpriteBatch().Begin();
            myGame.GetSpriteBatch().Draw(sprite, new Rectangle((int)position.X, (int)position.Y, 
                (int)taille.X, (int)taille.Y), 
                Color.White);
            myGame.GetSpriteBatch().Draw(sprite, new Rectangle((int)position.X+5, (int)position.Y+5, 
                myGame.getVie(), (int)taille.Y-10),
                Color.Blue);
            myGame.GetSpriteBatch().End();

            base.Draw(gameTime);
        }
    }
}
