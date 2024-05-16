using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    sealed class MyClass//sealed class is a class which means no other class can access it to inherit
    {
        private MyClass() { }   //to create it no other class can create direct object of this class
        private static MyClass instance;
        private static object instanceLock = new object();


        //global static method
        public static MyClass GetIntance()
        {
            //to save time application will be faster. 
            if (instance == null)//instance null then access it if multiple thread wait other and access it one inside lock;
            {

                lock (instanceLock)//In multithreading one thread go inside here and check instance and other threads wait here 
                {
                    if (instance == null) { instance = new MyClass(); }
                }
            }
            return instance; 
        
        
        } 
    }
}
