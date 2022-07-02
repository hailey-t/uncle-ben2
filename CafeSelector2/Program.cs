namespace CafeSelector2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Decadent decadent = new Decadent();
            BetweenFriends betweenFriends = new BetweenFriends();
            Vignette vignette = new Vignette();
            Starbucks starbucks = new Starbucks();

            //beginning of interactive program
            Console.WriteLine("Cafes in Warner Robins:\nDecadent Dessert Bar\nBetween Friends Coffee\nCafe Vignette\nStarbucks");
            Console.WriteLine("\n[Find details about a specific cafe]");
            Console.WriteLine("Select a cafe:");
            while (true)
            {
                Console.WriteLine("\n1) Decadent Dessert Bar\n2) Between Friends Coffee\n3) Cafe Vignette\n4) Starbucks");

                // access field and method of base class
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Decadent Dessert Bar");
                        decadent.allDisplay(false, 4.7f, 8.9f, "$$", false);
                        break;
                    case 2:
                        Console.WriteLine("Between Friends Coffee");
                        betweenFriends.allDisplay(true, 4.9f, 8.9f, "$", true);
                        break;
                    case 3:
                        Console.WriteLine("Cafe Vignette");
                        vignette.allDisplay(false, 4.1f, 1.7f, "$$$", true);
                        break;
                    case 4:
                        Console.WriteLine("Starbucks");
                        starbucks.allDisplay(true, 4.3f, 6.7f, "$$", true);
                        break;
                    default:
                        Console.WriteLine("Invalid option, moving on because I need to show I can call methods from inherited classes :)");
                        break;
                }

                // access method from inherited class
                Console.WriteLine("\nSee specialties of all cafes: (y/n)");
                if (Console.ReadLine().ToLower()[0] == 'y')
                {
                    decadent.dSpecialty();
                    betweenFriends.bSpecialty();
                    vignette.vSpecialty();
                    starbucks.sSpecialty();
                }
            }
        }
    }
}