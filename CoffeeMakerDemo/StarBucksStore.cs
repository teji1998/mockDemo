using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMakerDemo
{
    public class StarBucksStore
    {
        private readonly IMakeACoffee service;
        public StarBucksStore(IMakeACoffee service)
        {
            this.service = service;
        }

        public string OrderCoffee(int sugarPerSpoon, int CoffeeCount)
        {
            if (service.CheckingIngredientsAvailability())
            {
                return service.CoffeeMaking(sugarPerSpoon, CoffeeCount);
            }
            else
            {
                return "Sorry, coffee unavailable";
            }
        }
    }
}
