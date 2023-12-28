 using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System;

namespace Sprint2_Attempt3
{
    internal class Globals
    {
        public const float scale = 3.0f;
        public const int ScreenHeight = 725;
        public const int ScreenWidth = 800;
        public const int YOffset = 175;
        public const int NumberOfRooms = 19;
        public static Dictionary<int, Rectangle> FloorGrid = new Dictionary<int, Rectangle>();
     
        public static int FindIndex(int count, int step, int length)
        {
            int index = Math.Min(count / step, length - 1);
            return index;
        }

        public static void MakeFloorGrid()
        {
            int i = 1;
            for (int y = 100 + Globals.YOffset; y <= 400 + Globals.YOffset; y += 50)
            {
                for (int x = 100; x <= 650; x += 50)
                {
                    FloorGrid.Add(i, new Rectangle(x, y, 50, 50));
                    
                    i++;
                }
            }
        }
        
       
       
       


    }

}
