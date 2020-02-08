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
            Singleton singleton2 = null;
            
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
        // lock is used to make sure that part when instance is returned
        // can be accesed only by one and only one thread at time
        private static readonly object _lock = new object(); 

        private Singleton()
        {

        }
        public static Singleton Instance()
        {

            // locking is memory expensive operation - check if there is an actual need for it
            // there isn't if it hasn't been created yet
            if(_singleton != null)
            {
                lock (_lock)
                {
                    if (_singleton == null)
                        _singleton = new Singleton();
                
                }
            } 
                return _singleton;

        }
    }

}
