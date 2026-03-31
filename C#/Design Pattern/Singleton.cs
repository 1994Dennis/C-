using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern
{
    public class Singleton
    {
        public class LoggerWithoutSingleton
        {
            public int LogCount = 0;

            public void Log(string message)
            {
                LogCount++;
                Console.WriteLine($"[{LogCount}] {message}");
            }
        }
       
    }
    public sealed class LoggerWithSingleton
    {
        //This variable value will be increment by 1 each time the object of the class is created
        private static int Counter = 0;

        //This variable is going to store the Singleton Instance
        private static LoggerWithSingleton Instance = null;

        //The following Static Method is going to return the Singleton Instance
        public static LoggerWithSingleton GetInstance()
        {
            //If the variable instance is null, then create the Singleton instance 
            //else return the already created singleton instance
            //This version is not thread safe
            if (Instance == null)
            {
                Instance = new LoggerWithSingleton();
            }

            //Return the Singleton Instance
            return Instance;
        }

        //Constructor is Private means, from outside the class we cannot create an instance of this class
        private LoggerWithSingleton()
        {
            //Each Time the Constructor called, increment the Counter value by 1
            Counter++;
            Console.WriteLine("Counter Value " + Counter.ToString());
        }

        //The following can be accesed from outside of the class by using the Singleton Instance
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

}
