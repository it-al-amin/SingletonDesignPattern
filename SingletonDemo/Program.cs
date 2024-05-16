using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass mc=new MyClass(); can not create it
            //same object return different way but single object;
            MyClass obj=MyClass.GetIntance();
            MyClass obj1 = MyClass.GetIntance();
            MyClass obj2 = MyClass.GetIntance();
        }
    }
}
