using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMakerDemo
{
    public class StarBucks : IMakeACoffee
    {
        public bool CheckingIngredientsAvailability()
        {
            return true;

        }

        string IMakeACoffee.CoffeeMaking(int sugarPerSpoon, int CoffeePack)
        {
            throw new NotImplementedException();

        }

        public class StubStarBucks : IMakeACoffee
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
}
