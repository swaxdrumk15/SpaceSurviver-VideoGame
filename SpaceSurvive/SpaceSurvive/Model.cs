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
    class Model
    {
        private Vector2 _size;
        private Texture2D _img;

        public Model(Texture2D img)
        {
            _img = img;
            _size = GameUtil.ImageSize(img);
        }

        public Model(Texture2D img, float factor)
        {
            _img = img;
            _size = GameUtil.ImageSize(img) * factor;
        }

        public Texture2D getResource()
        {
            return _img;
        }

        public Vector2 getSize()
        {
            return _size;
        }
    }
}
