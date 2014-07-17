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
    class AwayFromBoundModifier : Interfaces.IModify
    {
        public void Modify(GameObject obj)
        {
            Vector2 loc = obj.Location;
            Vector2 size = obj.Model.getSize();
            float bottom = obj.Model.getSize().Y + obj.Location.Y;
            if (bottom >= GameUtil.ScreenSize.Y)
            {
                obj.DeleteObject = true;
            }

        }
    }
}
