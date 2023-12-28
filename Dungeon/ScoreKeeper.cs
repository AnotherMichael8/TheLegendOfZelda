using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Items;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon
{
    internal class ScoreKeeper
    {
        private static IAnimatedItemSprite sprite = (IAnimatedItemSprite)ItemSpriteFactory.Instance.CreateDigitSprite();
        private int score;
        private int time;
        private int loop;
        public ScoreKeeper(int score, int time) 
        { 
            this.score = score;
            this.time = time / 60;
            loop = 0;
        }
        private static Rectangle GetCount(char i)
        {
            Rectangle rectangle = new Rectangle(271 + ((i - 48) * 9), 131, 8, 8);
            if (i == ' ') { rectangle = new Rectangle(); }
            return rectangle;
        }
        public void SetCounter(int counter)
        {
            this.time = counter / 60;
        }
        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch, int x, int y)
        {
            if(time >= 10)
            {
                sprite.Draw(spriteBatch, new Rectangle(x, y, 26, 26), GetCount(time.ToString()[0]));
                sprite.Draw(spriteBatch, new Rectangle(x + 26, y, 26, 26), GetCount(time.ToString()[1]));
            }
            sprite.Draw(spriteBatch, new Rectangle(x, y, 26, 26), GetCount(time.ToString()[0]));
        }
    }
}
