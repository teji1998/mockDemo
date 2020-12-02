using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMakerDemo
{
     public interface IMakeACoffee
    {
        bool CheckingIngredientsAvailability();
        string CoffeeMaking(int sugarPerSpoon, int CoffeePack);
    }
}
