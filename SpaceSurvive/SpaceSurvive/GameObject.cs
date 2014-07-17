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
    class GameObject
    {
        public Model Model;
        public Color Color;
        public Vector2 Location;
        public Vector2 Velocity;
        public float Impulse;
        public List<Interfaces.IModify> Modifiers;
        public bool DeleteObject = false;


        public GameObject(Model model, Vector2 location, float impulse, Color color)
        {
            Model = model;
            Color = color;
            Impulse = impulse;
            Location = location;
            Velocity = Vector2.Zero;
            Modifiers = new List<Interfaces.IModify>();
        }

        public void Modify()
        {
            this.Location += this.Velocity;
            foreach (Interfaces.IModify modifier in Modifiers)
            {
                modifier.Modify(this);
            }
        }

        public void Draw()
        {
            GameUtil.spriteBatch.Draw(
                Model.getResource(),
                new Rectangle(
                    (int)this.Location.X,
                    (int)this.Location.Y,
                    (int)Model.getSize().X,
                    (int)Model.getSize().Y
                    ),
                    Color
                );
        }
    }
}
