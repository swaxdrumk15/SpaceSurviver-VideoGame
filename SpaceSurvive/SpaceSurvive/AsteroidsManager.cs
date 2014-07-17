using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceSurvive
{
    class AsteroidsManager
    {
        private List<Asteroid> asteroidList;
        private int maxAsteroid;

        public AsteroidsManager()
        {
            maxAsteroid = 10;
            asteroidList = new List<Asteroid>();
        }

        private void generate()
        {
            if (asteroidList.Count < maxAsteroid)
            {
                    asteroidList.Add(new Asteroid());
            }
        }

        public void Modify()
        {
            for (int i = 0; i < asteroidList.Count; i++)
            {
                if (asteroidList[i].DeleteObject)
                    asteroidList.Remove(asteroidList[i]);
            }
            generate();
            foreach (Asteroid asteroid in asteroidList)
            {
                asteroid.Modify();
            }
        }

        public void Draw()
        {
            foreach (Asteroid asteroid in asteroidList)
            {
                asteroid.Draw();
            }
        }
    }
}
