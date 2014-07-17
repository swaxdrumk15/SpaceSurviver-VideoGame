using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace SpaceSurvive.Modifiers
{
    class ScreenBoundModifier : Interfaces.IModify
    {
        public void Modify(GameObject obj)
        {
            Vector2 loc = obj.Location;
            Vector2 size = obj.Model.getSize();
            Vector2 otherCorner = size + loc;
            if (loc.X < 0)
            {
                obj.Location.X = 0;
            }
            else if (otherCorner.X > GameUtil.GameScreenSize.X)
            {
                obj.Location.X = GameUtil.GameScreenSize.X - size.X;
            }
        }
    }
}
