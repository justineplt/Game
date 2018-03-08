using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Escape_numericGame
{
    public class Objet2D : Microsoft.Xna.Framework.DrawableGameComponent
    {
        public Texture2D sprite;
        public Vector2 position;
        public Vector2 taille;
        private String chemin;
        protected Game1 myGame;

        public Objet2D(Game game, String chemin, Vector2 taille) : base(game)
        {
            this.myGame = (Game1)this.Game;
            this.chemin = chemin;
            this.taille = taille;
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            this.sprite = ((Game1)this.Game).Content.Load<Texture2D>(chemin);
            base.LoadContent();
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }


    }
}
