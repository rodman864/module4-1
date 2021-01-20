using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using module3.MyClasses;
using module3.Module;

namespace module3
{
    class Program
    {
        static void Main(string[] args)
        {
            WeddingCake<string> MyClasses = new WeddingCake<string>();
            MyClasses.Flavor = "Vanilla";
            
            BirthdayCake<string> Module = new BirthdayCake<string>();
            Module.Flavor = "Chocolate";

            Console.WriteLine(MyClasses.getMyFlavor());
            Console.WriteLine(Module.getMyFlavor());


            Console.WriteLine("I love my wedding cake because it has the flavor of" + MyClasses.Flavor);
            Console.WriteLine("I don't like my birthday cake because it has the flavor of " + Module.Flavor);




        }
    }
}

