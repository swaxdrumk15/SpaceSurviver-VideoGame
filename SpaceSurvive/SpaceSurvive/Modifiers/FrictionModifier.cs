using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceSurvive.Modifiers
{
    class FrictionModifier : Interfaces.IModify
    {
        public float Friction = 0.05f;

        public void Modify(GameObject obj)
        {
            obj.Velocity *= (1 - this.Friction);
        }
    }
}
