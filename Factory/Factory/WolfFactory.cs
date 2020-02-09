using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class WolfFactory : EnemyFactory
    {
        public override IEnemy Create(double Health, double Strength) => new EnemyWolf(Health,Strength);

    }
}
