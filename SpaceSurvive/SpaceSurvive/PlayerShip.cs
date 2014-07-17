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

namespace SpaceSurvive
{
    class PlayerShip : GameObject
    {
        public PlayerShip()
            : base(GameUtil.getModel("player"), GameUtil.ScreenMiddle(), 0.1f, Color.White)
        {
            this.Modifiers.Add(new Modifiers.ScreenBoundModifier());
            this.Modifiers.Add(new Modifiers.UserImpulseModifier());
            this.Modifiers.Add(new Modifiers.FrictionModifier());
        }
    }
}
