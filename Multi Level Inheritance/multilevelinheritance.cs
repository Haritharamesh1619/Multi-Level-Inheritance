﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Level_Inheritance
{
    public class multilevelinheritance
    {
        public class Animal

        {
            public void eat() { Console.WriteLine("Eating..."); }

        }

        public class Dog : Animal

        {
            public void bark() { Console.WriteLine("Barking..."); }

        }

        public class BabyDog : Dog

        {
            public void weep() { Console.WriteLine("Weeping..."); }
        }

        static void Main(string[] args)
        {
            BabyDog d1 = new BabyDog();

            d1.eat();

            d1.bark();

            d1.weep();

            Console.ReadKey();

        }
    }
}
