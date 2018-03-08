using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Escape_numericGame
{
    public class Camera : Microsoft.Xna.Framework.GameComponent
    {
        Vector3 cameraPosition;
        Vector3 cameraLookAt;

        private Matrix ProjectionMatrix;
        private Matrix ViewMatrix;

        public Camera(Game game): base(game)
        {
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public void setLookAt(Vector3 l)
        {
            this.cameraLookAt = l;
        }

        public void setPosition(Vector3 p)
        {
            this.cameraPosition = p;
        }

        public Matrix getProjection()
        {
            return this.ProjectionMatrix;
        }

        public Matrix getView()
        {
            return this.ViewMatrix;
        }

        public override void Update(GameTime gameTime)
        {
            this.ViewMatrix = Matrix.CreateLookAt(cameraPosition, cameraLookAt,Vector3.Up);

            this.ProjectionMatrix = Matrix.CreatePerspectiveFieldOfView( 
                MathHelper.ToRadians(45.0f), 
                ((Game1)this.Game).GetGraphicsDeviceManager().GraphicsDevice.Viewport.AspectRatio,
                1.0f,
                10000.0f);

            base.Update(gameTime);
        }
    }
}