using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMakerDemo
{
    public class FakeStarBuckStore : IMakeACoffee
    {
        public bool CheckingIngredientsAvailability()
        {
            return true;
        }

        public string CoffeeMaking(int sugarPerSpoon, int CoffeePack)
        {
            return "Your order is received";
        }

    }
    
}
