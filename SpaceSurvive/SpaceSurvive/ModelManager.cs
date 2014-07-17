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
    class ModelManager
    {
        private Dictionary<string, Model> ModelMapper = new Dictionary<string, Model>();

        public void setModel(Texture2D img, float factor, string name)
        {
            if (factor <= 0.0)
                factor = 1.0f;
            ModelMapper.Add(name, new Model(img, factor));
        }

        public Model getModel(string name)
        {
            if (ModelMapper.ContainsKey(name))
                return ModelMapper[name];
            // TODO: print to the log
            return null;
        }
    }
}
