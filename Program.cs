using System;
using System.Collections.Generic;
using Models;

namespace Introduction_To_OOP
{

  class Program
    { 
    public static void Main()
        {

            Pigeon pippa = new Pigeon("Pippa", "Grey");
            pippa.Speak();
            pippa.Fly();
            pippa.EatPizza();
            pippa.Sleep();

            Penguin pingu = new Penguin("Pingu", "Black & White");
            pingu.Speak();
            pingu.Fly();

            Parrot parry = new Parrot("Parry", "Colourful");
            parry.Speak();
            parry.Fly();

        }
    }
}

