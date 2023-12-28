using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.WallBlocks;

namespace Sprint2_Attempt3.Collision
{
    internal class CheckPlayerHitWallCollision
    {
        public List<IWall> wallBlocks;
        
        public CheckPlayerHitWallCollision(Link link)
        {
            wallBlocks = IWall.WallBlocks; 
        }
        
        public static bool CheckPlayerWallCollision(ILink link, IWall wall)
        {
            Rectangle linkRectangle = link.GetHitBox();
                if (link.GetHitBox().Intersects(wall.GetHitBox()))
                {
                    PlayerBlockHandler.HandleLinkBlockCollision(linkRectangle, wall.GetHitBox(), link);
                    return true;
                }
            return false;
        }
    }
}