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
    class Asteroid : GameObject
    {
        public Asteroid()
            : base(GameUtil.getModel("asteroid"), GameUtil.RandomVector2OnGameScreen(), 0.1f, Color.White)
        {
            this.Modifiers.Add(new Modifiers.ConstantMoveModifier());
            this.Modifiers.Add(new Modifiers.AwayFromBoundModifier());
        }

        public Asteroid(float impulse)
            : base(GameUtil.getModel("asteroid"), GameUtil.RandomVector2OnGameScreen(), impulse, Color.White)
        {
            this.Modifiers.Add(new Modifiers.ConstantMoveModifier());
            this.Modifiers.Add(new Modifiers.AwayFromBoundModifier());
        }
    }
}
