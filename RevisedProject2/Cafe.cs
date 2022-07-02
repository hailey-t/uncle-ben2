using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisedProject2
{
    public class Cafe
    {
        public string Name { get; set; }
        public float Review { get; set; }
        public float Distance { get; set; }
        public string Price { get; set; }
        public bool OrderOnline { get; set; }

        public virtual void SeeMenu()
        {
            Console.WriteLine("Checking out {0}'s Menu...", Name);
        }

        public void seeDetails()
        {
            Console.WriteLine();
            Console.WriteLine($"The cafe is rated {Review} out of 5 stars.");
            Console.WriteLine($"The distance of the cafe from the Synergy Center is {Distance} miles.");
            Console.WriteLine($"The cafe's average prices are {Price}.");
            Console.WriteLine($"This cafe takes online orders: {OrderOnline}");
        }
    }

    class Decadent : Cafe
    {
        public List<string> menu = new List<string>()
        {
            "Coffee - $2.75" ,
            "Iced Coffee - $3.25" ,
            "Blackeye - $4.75" ,
            "Cold Brew - $3.85" ,
            "Nitro Brew - $4.75" ,
            "Sweet Cream Cold Brew - $4.85" ,
            "Espresso - $2.55" ,
            "Americano - $3.25" ,
            "Cortado - $3.75" ,
            "Cappuccino - $4.95" ,
            "Macchiato - $4.95" ,
            "Hot Tea - $2.75" ,
            "London Fog - $4.85" ,
            "Hot Chocolate - $3.75" ,
            "Latte - $4.95" ,
            "Smoothie - $5.50" ,
            "Frappe - $5.75" ,
            "Soda - $1.50" ,
            "Orange Juice - $2.50" ,
            "Milk - $2.25" ,
            "Lemonade - $2.95" ,
            "Gatorade - $2.25" ,
            "Milkshake - $6.50" ,
        };

        public List<string> foodMenu = new List<string>()
        {
            "Cannoli - $3.85" ,
            "Chocolate Covered Cannoli - $4.00" ,
            "Brownie - $3.75" ,
            "Crispy Treat - $3.50" ,
            "Magic Bar - $3.75" ,
            "Banana Pudding - $4.00" ,
            "Cookie Sandwich - $3.75" ,
            "Bundt Cake - $3.95" ,
            "Cake Parfait - $5.50" ,
            "Today’s Cupcake - $3.75" ,
            "Lemon Bar - $3.75" ,
            "Pecan Bourbon Bar - $3.75" ,
            "Cookies - $1.00" ,
            "French Macarons - $2.00" ,
            "Coconut Macaroons - $1.50" ,
            "Meringues - $4.00" ,
            "Skillets - $8.25"
        };

        public List<string> coffeeFlavors = new List<string>
        {
            "Almond Mocha" ,
            "Brown Butter & Toffee" ,
            "Butter Pecan" ,
            "Caramel" ,
            "Caramel Pumpkin Spice" ,
            "Chai" ,
            "Cinnamon Amaretto" ,
            "Coconut Mocha" ,
            "Dulche De Leche" ,
            "Gingerbread" ,
            "Golden Tumeric" ,
            "Hazelnut Mocha" ,
            "Hot Mess" ,
            "Maple Spice" ,
            "Mocha" ,
            "Peppermint Mocha" ,
            "Praline" ,
            "Pumpkin Spice" ,
            "Salted Caramel Cupcake" ,
            "Sea Salt Caramel Toffee" ,
            "Spiced Snowflake Mocha" ,
            "Toasted Almond Mocha" ,
            "Toasted Cinnamon Mocha" ,
            "Toffee Nut" ,
            "Wedding Cake" ,
            "White Chocolate" ,
            "White Pumpkin Mocha" ,
            "White Winter Spice" ,
            "Vanilla" ,
        };

        public override void SeeMenu()
        {
            base.SeeMenu();
            Console.WriteLine();
            foreach (var item in menu) // prints out menu
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Check out our new Lavender Coffee!");
        }
        public void seeFlavors() 
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Here is the selection of coffee flavors:");
            Console.WriteLine();
            foreach (var item in coffeeFlavors) 
            {
                Console.WriteLine(item);
            }
        }
        public void seeFood() 
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Here is the selection of foodstuffs:");
            Console.WriteLine();
            foreach (var item in foodMenu)
            {
                Console.WriteLine(item);
            }
        }
    }

    class BetweenFriends : Cafe
    {
        public List<string> menu = new List<string>()
        { 
            "Americano - $3.00",
            "Long Black - $2.50",
            "Espresso - $2.00",
            "Espresso Con Panna - $3.50",
            "Flipped Latte - $3.00",
            "Macchiato - $3.50",
            "Latte - $2.75",
            "Cappuccino - $3.75",
            "Frappe - $4.00"
        };

        public List<string> foodMenu = new List<string>()
        {   
            "Cinnamon Rolls - $4.00",
            "Apple Fritter - $2.95",
            "Danish - $3.00",
            "Muffins - $3.00",
            "Scone - $3.00",
            "Hand Rolled Bagels - $3.75",
            "Butterbeer Cinnamon Roll - $4.00",
            "Belgian Waffles - $3.75",
            "French Toast - $6.75"
        };

        public List <string> bookList = new List<string>()
        {
            "\nBooks by Wanda Jenning and Louise Turner - \n\tDirty Laundry\n\tSaints and Sinners\n\tColor Me Crazy\n\tRhinestone Recipes\n\tDouble Trouble",
            "\nBooks by Jaimie E. Miller - \n\tDon't Forget You Love Me\n\tThe Long Way Home\n\tThe Poet's Gift\n\tSkeleton Key",
            "\nBooks by Jennifer B. Duffy - \n\tBeneath the Mulberry Tree\n\tThe Face in the Mirror\n\t'Till the Stars Stop Shining",
            "\nBooks by Cat Webling - \n\tArtificial Intelligence\n\tGhost"
        };
        public override void SeeMenu()
        {
            base.SeeMenu();
            Console.WriteLine();
            Console.WriteLine("- Also has iced versions of drinks");
            foreach (var item in menu) // prints out menu
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        public void seeFood()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Here is the selection of foodstuffs:");
            Console.WriteLine();
            foreach (var item in foodMenu)
            {
                Console.WriteLine(item);
            }
        }
        public void seeBooks()
        {
            Console.WriteLine();
            Console.WriteLine("Here is the selection of books avaliable:");
            foreach (var item in bookList)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Vignette : Cafe 
    {
       
    }

    class Starbucks : Cafe
    {
        
    }
}
