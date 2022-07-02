using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSelector2
{
    public class Cafe
    {
        public bool hasCoffee = true;
        public bool hasTea = true;
        public bool hasColdDrinks = true;
        public bool hasDesserts = true;
        public bool hasPastries = true;

        public void allDisplay(bool hasSavory, float review, float distance, string price, bool orderOnline)
        {
            Console.WriteLine($"Coffee: {hasCoffee}\nTea: {hasTea}\nCold Drinks: {hasColdDrinks}\nDesserts: {hasDesserts}\nPastries: {hasPastries}\nSavory Dishes: {hasSavory}");
            Console.WriteLine();
            Console.WriteLine($"The cafe is rated {review} out of 5 stars.");
            Console.WriteLine($"The distance of the cafe from the Synergy Center is {distance} miles.");
            Console.WriteLine($"The cafe's average prices are {price}.");
            Console.WriteLine($"This cafe takes online orders: {orderOnline}");
        }
    }

    class Decadent : Cafe  // derived class
    {
        public void dSpecialty() // example of method within derived class
        {
            Console.WriteLine("Decadent: Wide variety");
        }
    }
    class BetweenFriends : Cafe  // derived class
    {
        public void bSpecialty()
        {
            Console.WriteLine("Between Friends: Literary-themed cafe and world specialty beverages");
        }
    }
    class Vignette : Cafe  // derived class
    {
        public void vSpecialty()
        {
            Console.WriteLine("Vignette: Beignets");
        }
    }
    class Starbucks : Cafe  // derived class
    {
        public void sSpecialty()
        {
            Console.WriteLine("Starbucks: Drink cutomization");
        }
    }
}
