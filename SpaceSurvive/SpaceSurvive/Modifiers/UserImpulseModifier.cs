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
    class UserImpulseModifier : Interfaces.IModify
    {
        // TODO: move the keyboard setting to a new class (command pattern)
        public void Modify(GameObject obj)
        {
            KeyboardState state = Keyboard.GetState();
            if (state.IsKeyDown(Keys.Left))
            {
                obj.Velocity.X -= obj.Impulse;
            }
            if (state.IsKeyDown(Keys.Right))
            {
                obj.Velocity.X += obj.Impulse;
            }
        }
    }
}
