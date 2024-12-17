using EasyMonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EasyStart
{
    internal class Wombat : Actor
    {
        private float speed = 500;
        private Random random = new Random();
        private int score = 0;
        private int test = 10;




        private bool isDead = false;

        private void Showscore()
        {
            this.World.ShowText(
                "Score: " + score, 100, 910);
        }


        public bool IsDead
        {
            get
            {
                return isDead;
            }
        }


        public override void Update(GameTime gameTime)
        {
            Showscore();
            Move((float)gameTime.ElapsedGameTime.TotalSeconds * speed);
            if (isDead) return;

            var keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.W) && Y >= 0)
            {
                Rotation = 270f;
            }
            else if (keyboardState.IsKeyDown(Keys.S) && Y <= 1250)
            {
                Rotation = 90f;
            }
            else if (keyboardState.IsKeyDown(Keys.A) && X >= 0)
            {

                Rotation = 180f;
            }
            else if (keyboardState.IsKeyDown(Keys.D) && X <= 1250)
            {
                Rotation = 0f;
            }
        }
    }
}