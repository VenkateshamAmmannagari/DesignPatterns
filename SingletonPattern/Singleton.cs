using System;
namespace SingletonPattern
{
    public sealed class Singleton
    {
        //Create private static property to hold the object
        private static readonly Singleton instance = new Singleton();

        //Make constructor private to stop creating new instance of the class.
        private Singleton() 
        {
        }
        //return the objects
        public static Singleton Instance
        {
            get { return instance; }
        }

        public void GetDetails()
        {
            Console.WriteLine("Welecome to Preschool..!");
        }
    }
}

