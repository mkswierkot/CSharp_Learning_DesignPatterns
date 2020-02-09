using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public enum Enemies
    {
        Ogre,
        Wolf
    }
    public class Enemy
    {
        private readonly Dictionary<Enemies, EnemyFactory> _factories;

        public Enemy()
        {
            _factories = new Dictionary<Enemies, EnemyFactory>();

            _factories.Add(Enemies.Ogre, new OgreFactory());
            _factories.Add(Enemies.Wolf, new WolfFactory());
        }

        public IEnemy ExecuteCreation(Enemies enemy, double Health, double Strength) => _factories[enemy].Create(Health, Strength);
    }
}