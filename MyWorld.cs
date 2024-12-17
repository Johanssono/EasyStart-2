using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EasyMonoGame;
using Microsoft.Xna.Framework;

namespace EasyStart
{
    internal class MyWorld : World
    {
        private Random random = new Random();
        private Wombat my_wombat;


        public MyWorld() : base(1250, 950)
        {
            GameArt.Add("bluerock");
            GameArt.Add("wombat");
            GameArt.Add("brick");
            GameArt.Add("heart");

            BackgroundTileName = "bluerock";

            my_wombat = new Wombat();
            Add(my_wombat, "wombat", 1250 / 2, 950 / 2);
            //måste fixa så ormen kan spwna på random ställen utanför fönstret


            for (int i = 0; i < 3; i++)
            {
                Add(new Heart(), "herz", 40 + (i * 60), 40);
            }


            Add(new Snake(my_wombat), "snake", random.Next(1250, 2000), random.Next(950, 2000));

        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (my_wombat.IsDead)
            {
                MyWorld world = new MyWorld();
                EasyGame.Instance.ActiveWorld = world;
            }
        }

    }
}

