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
    class GameUtil
    {
        private static ModelManager gameModels = new ModelManager();
        private static Vector2 screenSize = new Vector2(1000, 480);
        private static Vector2 widgetHeight = new Vector2(0, 100);

        public static EventArgs emptyEventData = new EventArgs();
        public static Random Random = new Random();
        public static SpriteBatch spriteBatch;
        public static Vector2 GameScreenSize = ScreenSize - widgetHeight;
        public static Vector2 ScreenSize
        {
            get
            { return screenSize; }
            set
            {
                screenSize = value;
                GameScreenSize = screenSize - widgetHeight;
            }
        }
        public static Dictionary<string, float> objectSizes = new Dictionary<string, float>()
        {
            {"big", 2},
            {"avg", 1},
            {"sml", 0.5f}
        };

        public static void setModel(Texture2D image, float factor, string name)
        {
            gameModels.setModel(image, factor, name);
        }

        public static Model getModel(string name)
        {
            return gameModels.getModel(name);
        }

        public static Vector2 ImageSize(Texture2D image)
        {
            return new Vector2(image.Width, image.Height);
        }

        public static Vector2 ScreenMiddle()
        {
            return new Vector2(GameScreenSize.X / 2, GameScreenSize.Y);
        }

        public static float RandomFloat
        {
            get
            {
                return (float)Random.NextDouble();
            }
        }

        public static Vector2 RandomVector2(Vector2 limit)
        {
            return new Vector2(
                RandomFloat * limit.X,
                RandomFloat * limit.Y
                );
        }

        public static Vector2 RandomVector2OnGameScreen()
        {
            return RandomVector2(GameScreenSize);
        }

        public static void DrawBackground()
        {
            Model bgImg = getModel("background");
            spriteBatch.Draw(
                bgImg.getResource(),
                new Rectangle(
                    0,
                    0,
                    (int)bgImg.getSize().X,
                    (int)bgImg.getSize().Y
                    ),
                    Color.White
                );
        }
    }
}
