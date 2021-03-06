﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_in_the_Zoo
{
    class Mammal : Animal
    {
        public Mammal(string name) :base("")
        {
            this.name = name;
        }

        public Mammal(string name, int age, int legs, string gender) : base(name)
        {
            this.name = name;
            this.age = age;
            this.legs = legs;
            this.gender = gender;
        }

        public override string GetName()
        {
            return name;
        }

        public override void Greet()
        {
            Console.WriteLine("Kah-Kaah!");
        }

        public override string WantChild()
        {
            return $"{name}, want a child from my uterus";
        }
    }
}
