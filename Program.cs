using System;
using System.Collections.Generic;
using Models;

namespace Introduction_To_OOP
{

  class Program
    { 
    public static void Main()
        {
            Bird myBird = new Bird("Tweety", "Yellow");
            myBird.Speak();
            myBird.Fly();

            Pigeon pippa = new Pigeon("Pippa", "Grey");
            pippa.Speak();
            pippa.Fly();
            pippa.EatPizza();
            pippa.Sleep();

        }
    }
}

