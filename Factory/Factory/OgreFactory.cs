using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class OgreFactory : EnemyFactory
    {
 
        public override IEnemy Create(double Health, double Strength) => new EnemyOgre(Health, Strength);
    }
}
