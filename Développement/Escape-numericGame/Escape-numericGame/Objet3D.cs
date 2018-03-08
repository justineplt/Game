using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Escape_numericGame
{
    public class Objet3D: Microsoft.Xna.Framework.DrawableGameComponent
    {
        Model model;
        protected Game1 myGame;
        protected Vector3 position;
        protected Vector3 rotation;
        protected string chemin;
        protected float scale;

        public Objet3D(Game game, Vector3 position, Vector3 rotation, string chemin, float scale): base(game)
        {
            this.myGame = (Game1)this.Game;
            this.position = position;
            this.rotation = rotation;
            this.chemin = chemin;
            this.scale = scale;
        }

        protected override void LoadContent()
        {
            this.model = myGame.Content.Load<Model>(chemin);
            base.LoadContent();
        }

        void drawModel(Model model, Vector3 modelPosition, Vector3 rotation, float sc)
        {
            foreach (ModelMesh mesh in this.model.Meshes)
            {
                foreach (BasicEffect effect in mesh.Effects)
                {
                    effect.EnableDefaultLighting();
                    effect.PreferPerPixelLighting = true;
                    effect.World = Matrix.CreateFromYawPitchRoll(rotation.Y, rotation.X, rotation.Z) *
                        Matrix.CreateScale(sc) *
                        Matrix.CreateTranslation(modelPosition);
                    effect.Projection = myGame.getCamera().getProjection();
                    effect.View = ((Camera)myGame.getCamera()).getView();

                }
                mesh.Draw();
            }
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            this.drawModel(this.model, this.position, this.rotation, this.scale);
        }

    }
}