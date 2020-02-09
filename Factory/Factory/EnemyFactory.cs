using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public abstract class EnemyFactory  
    {
        public abstract IEnemy Create(double Health, double Strength);
    }
}
