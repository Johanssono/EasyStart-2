using EasyMonoGame;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyStart
{
    internal class Snake : Actor
    {
        private Wombat wombat;

        public Snake(Wombat wombat)
        {
            this.wombat = wombat;
        }

        public override void Update(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            TurnTowards(wombat.X, wombat.Y);
            Move(250 * deltaTime);
        }
    }
}
