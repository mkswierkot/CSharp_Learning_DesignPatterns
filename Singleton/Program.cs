using System;
using System.Threading;

namespace Singleton
{
    /*
    
        Singleton allows you to create only one instance of a class. It describes a way
        of creating a new object. By definition it helps you do two things: make sure only one instance
        of a class is created, and is accesible globally. It breaks a Single Responsibility principle.


     
    */
    class Program
    {
      
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.Instance();
            Singleton singleton1 = Singleton.Instance();
            Singleton singleton2;
            
            Thread t2 = new Thread(delegate ()
            {
                singleton2 = Singleton.Instance();               
            });
            t2.Start();
             
        }
    }

    public sealed class Singleton
    {
        private static Singleton _singleton;

        private Singleton()
        {

        }
        public static Singleton Instance()
        {
            if (_singleton == null)
                _singleton = new Singleton();

            return _singleton;
        }
    }

}
