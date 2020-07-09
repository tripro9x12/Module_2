﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public interface Edible
    {
        public string HowToEat();
    }
    public abstract class Fruit : Edible
    {
        public abstract string HowToEat();
    }
    public class Apple : Fruit
    {
        public override string HowToEat()
        {
            return "Apple could be slided";
        }
    }
    public class Orange : Fruit
    {
        public override string HowToEat()
        {
            return "Orange could be juiced";
        }

    }
}
