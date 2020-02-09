using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory1 = new Enemy().ExecuteCreation(Enemies.Wolf, 20.3, 30.3);
            var factory2 = new Enemy().ExecuteCreation(Enemies.Ogre, 30.3, 20.3);

            factory1.Attack();
            factory2.Attack();

            factory2.

        }
    }
}
