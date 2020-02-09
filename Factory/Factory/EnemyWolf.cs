using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class EnemyWolf : IEnemy
    {
        private double _health;
        private double _strength;
        public EnemyWolf(double Health, double Strength)
        {
            _health = Health;
            _strength = Strength;
        }
        public void Attack()
        {
            Console.WriteLine("Attacking");
        }
    }
}
