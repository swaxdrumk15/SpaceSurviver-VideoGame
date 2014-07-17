using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceSurvive.Modifiers
{
    class ConstantMoveModifier : Interfaces.IModify
    {
        public void Modify(GameObject obj)
        {
            obj.Velocity.Y += obj.Impulse;
        }
    }
}
